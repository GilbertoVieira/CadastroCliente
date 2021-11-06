using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Drawing;

namespace CadastroCliente
{
    public partial class frmcliente : Form
    {

        clsapoio clsapoio = new clsapoio();
        int codcliente = 0;

        public frmcliente()
        {
            InitializeComponent();
        }

        //FORMLOAD
        private void frmcliente_Load(object sender, EventArgs e)
        {
            limpaCampos();
            desabilitaCampos();
            btnovo.Focus();
            codcliente = 0;
            dtgdados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgdados.RowHeadersVisible = false;
            dtgdados.ReadOnly = true;
            mskcep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            msktelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        //CARREGAR CLIENTES CADASTRADOS
        private void carregaClientes()
        {
            try
            {
                clsapoio.stringBD();
                SqlCommand cmd = new SqlCommand("SELECT cod_cliente, nome, nasc, telefone, cep, endereco, num, complemento, bairro, municipio, estado FROM cliente", clsapoio.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable cliente = new DataTable();
                da.Fill(cliente);
                dtgdados.DataSource = cliente;
                dtgdados.Columns[0].HeaderText = "COD CLIENTE";
                dtgdados.Columns[1].HeaderText = "NOME";
                dtgdados.Columns[2].HeaderText = "NASCIMENTO";
                dtgdados.Columns[3].HeaderText = "TELEFONE";
                dtgdados.Columns[4].HeaderText = "CEP";
                dtgdados.Columns[5].HeaderText = "ENDEREÇO";
                dtgdados.Columns[6].HeaderText = "NUMERO";
                dtgdados.Columns[7].HeaderText = "COMPLEMENTO";
                dtgdados.Columns[8].HeaderText = "BAIRRO";
                dtgdados.Columns[9].HeaderText = "MUNICIPIO";
                dtgdados.Columns[10].HeaderText = "ESTADO";
                //------------------------//
                dtgdados.Columns[0].Width = 70;
                dtgdados.Columns[1].Width = 300;
                dtgdados.Columns[2].Width = 100;
                dtgdados.Columns[3].Width = 110;
                dtgdados.Columns[4].Width = 110;
                dtgdados.Columns[5].Width = 200;
                dtgdados.Columns[6].Width = 70;
                dtgdados.Columns[7].Width = 150;
                dtgdados.Columns[8].Width = 150;
                dtgdados.Columns[9].Width = 150;
                dtgdados.Columns[10].Width = 70;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                clsapoio.desconectarBD();
                dtgdados.ClearSelection();
            }
        }

        //CADASTRO DE CLIENTE
        private void salvaCliente()
        {

            if ((txtnome.Text == "") || (msknasc.Text == "") || (msktelefone.Text == ""))
            {
                MessageBox.Show("SÃO OBRIGATÓRIOS O PREENCHIMENTO DOS CAMPOS NOME, NASCIMENTO E TELEFONE.", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    clsapoio.stringBD();
                    SqlCommand cmd = new SqlCommand("INSERT INTO cliente(nome, nasc, telefone, cep, endereco, num, complemento, bairro, municipio, estado) VALUES (@nome, @nasc, @telefone, @cep, @endereco, @num, @complemento, @bairro, @municipio, @estado)", clsapoio.conn);
                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@nasc", msknasc.Text);
                    cmd.Parameters.AddWithValue("@telefone", msktelefone.Text);
                    cmd.Parameters.AddWithValue("@cep", mskcep.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtendereco.Text);
                    cmd.Parameters.AddWithValue("@num", txtnumero.Text);
                    cmd.Parameters.AddWithValue("@complemento", txtcomplemento.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtbairro.Text);
                    cmd.Parameters.AddWithValue("@municipio", txtmunicipio.Text);
                    cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DADOS SALVOS COM SUCESSO!", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    clsapoio.desconectarBD();
                    limpaCampos();
                    desabilitaCampos();
                    btsalvar.Enabled = false;
                    btnovo.Enabled = true;
                    btexcluir.Enabled = false;
                    carregaClientes();
                }
            }

        }

        //ALTERAR CLIENTE
        private void alteraCliente()
        {
            if ((txtnome.Text == "") || (msknasc.Text == "") || (msktelefone.Text == ""))
            {
                MessageBox.Show("SÃO OBRIGATÓRIOS O PREENCHIMENTO DOS CAMPOS NOME, NASCIMENTO E TELEFONE.", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    clsapoio.stringBD();
                    SqlCommand cmd = new SqlCommand("UPDATE cliente SET nome='" + txtnome.Text + "', nasc='" + DateTime.Parse(msknasc.Text) + "', telefone='" + msktelefone.Text + "' , cep = '" +
                        Convert.ToInt32(mskcep.Text) + "', endereco='" + txtendereco.Text + "', num = '" + Convert.ToInt32(txtnumero.Text) + "', complemento = '" + txtcomplemento.Text +
                        "', bairro = '" + txtbairro.Text + "', municipio = '" + txtmunicipio.Text + "', estado = '" + txtestado.Text +
                        "' WHERE cod_cliente=" + codcliente, clsapoio.conn);
                    MessageBox.Show("DADOS ATUALIZADOS COM SUCESSO!", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    clsapoio.desconectarBD();
                    limpaCampos();
                    desabilitaCampos();
                    btsalvar.Enabled = false;
                    btnovo.Enabled = true;
                    btexcluir.Enabled = false;
                    carregaClientes();
                }
            }

        }

        //EXCLUIR CLIENTE
        private void excluiCliente()
        {
            if (MessageBox.Show("DESEJA REALMENTE EXCLUIR O CADASTRO DO CLIENTE? \nEXCLUSÃO IRREVERSÍVEL!", "CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    clsapoio.stringBD();
                    SqlCommand cmd = new SqlCommand("DELETE FROM cliente WHERE cod_cliente=@cod_cliente", clsapoio.conn);
                    cmd.Parameters.AddWithValue("@cod_cliente", codcliente);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EXCLUÍDO COM SUCESSO!", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    clsapoio.desconectarBD();
                    limpaCampos();
                    desabilitaCampos();
                    btsalvar.Enabled = false;
                    btnovo.Enabled = true;
                    btexcluir.Enabled = false;
                    carregaClientes();
                }
            }
        }

        //DESABILITAR OS CAMPOS
        private void desabilitaCampos()
        {
            txtnome.Enabled = false;
            msknasc.Enabled = false;
            msktelefone.Enabled = false;
            mskcep.Enabled = false;
            txtendereco.Enabled = false;
            txtnumero.Enabled = false;
            txtcomplemento.Enabled = false;
            txtbairro.Enabled = false;
            txtmunicipio.Enabled = false;
            txtestado.Enabled = false;
            btsalvar.Enabled = false;
            btexcluir.Enabled = false;
        }

        //HABILITA CAMPOS
        private void habilitaCampos()
        {
            txtnome.Enabled = true;
            msknasc.Enabled = true;
            msktelefone.Enabled = true;
            mskcep.Enabled = true;
            txtendereco.Enabled = true;
            txtnumero.Enabled = true;
            txtcomplemento.Enabled = true;
            txtbairro.Enabled = true;
            txtmunicipio.Enabled = true;
            txtestado.Enabled = true;
            btsalvar.Enabled = true;
            txtnome.Focus();
        }

        //LIMPA OS CAMPOS
        private void limpaCampos()
        {
            txtnome.Text = "";
            msknasc.Text = "";
            msktelefone.Text = "";
            mskcep.Text = "";
            txtendereco.Text = "";
            txtnumero.Text = "";
            txtcomplemento.Text = "";
            txtbairro.Text = "";
            txtmunicipio.Text = "";
            txtestado.Text = "";
            dtgdados.DataSource = "";
            codcliente = 0;
        }

        //FECHAR O SISTEMA
        private void lblfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEJA ENCERRAR O SISTEMA?", "CLIENTES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //MINIMIZAR O SISTEMA
        private void lblminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //BOTÃO NOVO
        private void btnovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
            limpaCampos();
        }

        //BOTÃO PESQUISAR
        private void btcarregar_Click(object sender, EventArgs e)
        {
            carregaClientes();
        }

        //BOTÃO SALVAR
        private void btsalvar_Click(object sender, EventArgs e)
        {
            if (codcliente == 0)
            {
                salvaCliente();
            }
            else
            {
                alteraCliente();
            }
        }

        //BOTÃO EXCLUIR
        private void btexcluir_Click(object sender, EventArgs e)
        {
            excluiCliente();
        }

        //PEGAR INFORMAÇÕES DO DATAGRID E JOGAR NO 
        private void dtgdados_DoubleClick(object sender, EventArgs e)
        {
            codcliente = Convert.ToInt16(dtgdados.CurrentRow.Cells[0].Value);
            txtnome.Text = dtgdados.CurrentRow.Cells[1].Value.ToString();
            msknasc.Text = dtgdados.CurrentRow.Cells[2].Value.ToString();
            msktelefone.Text = dtgdados.CurrentRow.Cells[3].Value.ToString();
            mskcep.Text = dtgdados.CurrentRow.Cells[4].Value.ToString();
            txtendereco.Text = dtgdados.CurrentRow.Cells[5].Value.ToString();
            txtnumero.Text = dtgdados.CurrentRow.Cells[6].Value.ToString();
            txtcomplemento.Text  = dtgdados.CurrentRow.Cells[7].Value.ToString();
            txtbairro.Text = dtgdados.CurrentRow.Cells[8].Value.ToString();
            txtmunicipio.Text = dtgdados.CurrentRow.Cells[9].Value.ToString();
            txtestado.Text = dtgdados.CurrentRow.Cells[10].Value.ToString();
            habilitaCampos();
            btexcluir.Enabled = true;
        }

        //MUDAR DE CAMPO COM ENTER
        public void mudaEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }

        //BUSCAR ENDEREÇO PELO CEP
        private void mskcep_Leave(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + mskcep.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("SERVIDOR INDIPONÍVEL", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP NÃO ENCONTRADO", "CLIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    mskcep.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtendereco.Text = valor[1].ToString();
                                txtendereco.CharacterCasing = CharacterCasing.Upper;
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtbairro.Text = valor[1].ToString();
                                txtbairro.CharacterCasing = CharacterCasing.Upper;
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtmunicipio.Text = valor[1].ToString();
                                txtmunicipio.CharacterCasing = CharacterCasing.Upper;
                            }

                            //Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtestado.Text = valor[1].ToString();
                                txtestado.CharacterCasing = CharacterCasing.Upper;
                            }

                            cont++;
                        }
                    }
                }
            }
        }

        //MOVENDO FORM PELA TELA
        bool mouseClicked;
        Point clickedAt;

        private void pnsuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }
        private void pnsuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            mouseClicked = true;
            clickedAt = e.Location;
        }
        private void pnsuperior_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
    }
}
