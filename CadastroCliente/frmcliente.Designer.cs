namespace CadastroCliente
{
    partial class frmcliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcarregar = new System.Windows.Forms.Button();
            this.btnovo = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgdados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskcep = new System.Windows.Forms.MaskedTextBox();
            this.msknasc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.pnsuperior = new System.Windows.Forms.Panel();
            this.lblminimizar = new System.Windows.Forms.Label();
            this.lblfechar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnsuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btcarregar);
            this.panel1.Controls.Add(this.btnovo);
            this.panel1.Controls.Add(this.btexcluir);
            this.panel1.Controls.Add(this.btsalvar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pnsuperior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 533);
            this.panel1.TabIndex = 0;
            // 
            // btcarregar
            // 
            this.btcarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(75)))));
            this.btcarregar.FlatAppearance.BorderSize = 0;
            this.btcarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(163)))));
            this.btcarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcarregar.ForeColor = System.Drawing.Color.White;
            this.btcarregar.Location = new System.Drawing.Point(652, 473);
            this.btcarregar.Name = "btcarregar";
            this.btcarregar.Size = new System.Drawing.Size(120, 33);
            this.btcarregar.TabIndex = 15;
            this.btcarregar.Text = "PESQUISAR";
            this.btcarregar.UseVisualStyleBackColor = false;
            this.btcarregar.Click += new System.EventHandler(this.btcarregar_Click);
            // 
            // btnovo
            // 
            this.btnovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(75)))));
            this.btnovo.FlatAppearance.BorderSize = 0;
            this.btnovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(163)))));
            this.btnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnovo.ForeColor = System.Drawing.Color.White;
            this.btnovo.Location = new System.Drawing.Point(207, 473);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(120, 33);
            this.btnovo.TabIndex = 12;
            this.btnovo.Text = "NOVO";
            this.btnovo.UseVisualStyleBackColor = false;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(75)))));
            this.btexcluir.FlatAppearance.BorderSize = 0;
            this.btexcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(163)))));
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(503, 473);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(120, 33);
            this.btexcluir.TabIndex = 14;
            this.btexcluir.Text = "EXCLUIR";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(75)))));
            this.btsalvar.FlatAppearance.BorderSize = 0;
            this.btsalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(163)))));
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(357, 473);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(120, 33);
            this.btsalvar.TabIndex = 13;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgdados);
            this.groupBox2.Location = new System.Drawing.Point(11, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 259);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // dtgdados
            // 
            this.dtgdados.BackgroundColor = System.Drawing.Color.White;
            this.dtgdados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdados.Location = new System.Drawing.Point(17, 20);
            this.dtgdados.Name = "dtgdados";
            this.dtgdados.Size = new System.Drawing.Size(917, 223);
            this.dtgdados.TabIndex = 11;
            this.dtgdados.DoubleClick += new System.EventHandler(this.dtgdados_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtbairro);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtmunicipio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcomplemento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.txtendereco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskcep);
            this.groupBox1.Controls.Add(this.msknasc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.msktelefone);
            this.groupBox1.Location = new System.Drawing.Point(11, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 130);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "BAIRRO";
            // 
            // txtbairro
            // 
            this.txtbairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbairro.Location = new System.Drawing.Point(455, 94);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(187, 21);
            this.txtbairro.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(846, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "ESTADO";
            // 
            // txtestado
            // 
            this.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtestado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestado.Location = new System.Drawing.Point(849, 94);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(85, 21);
            this.txtestado.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(658, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "MUNICÍPIO";
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmunicipio.Location = new System.Drawing.Point(659, 94);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(171, 21);
            this.txtmunicipio.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "COMPLEMENTO";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcomplemento.Location = new System.Drawing.Point(313, 94);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(123, 21);
            this.txtcomplemento.TabIndex = 7;
            this.txtcomplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mudaEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "NÚMERO";
            // 
            // txtnumero
            // 
            this.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnumero.Location = new System.Drawing.Point(243, 94);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(55, 21);
            this.txtnumero.TabIndex = 6;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mudaEnter);
            // 
            // txtendereco
            // 
            this.txtendereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendereco.Location = new System.Drawing.Point(17, 94);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(209, 21);
            this.txtendereco.TabIndex = 5;
            this.txtendereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mudaEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ENDEREÇO";
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(17, 39);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(562, 21);
            this.txtnome.TabIndex = 1;
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mudaEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // mskcep
            // 
            this.mskcep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskcep.Location = new System.Drawing.Point(849, 39);
            this.mskcep.Mask = "99999-999";
            this.mskcep.Name = "mskcep";
            this.mskcep.Size = new System.Drawing.Size(85, 21);
            this.mskcep.TabIndex = 4;
            this.mskcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mudaEnter);
            this.mskcep.Leave += new System.EventHandler(this.mskcep_Leave);
            // 
            // msknasc
            // 
            this.msknasc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msknasc.Location = new System.Drawing.Point(607, 39);
            this.msknasc.Mask = "00/00/0000";
            this.msknasc.Name = "msknasc";
            this.msknasc.Size = new System.Drawing.Size(94, 21);
            this.msknasc.TabIndex = 2;
            this.msknasc.ValidatingType = typeof(System.DateTime);
            this.msknasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mudaEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NASC";
            // 
            // msktelefone
            // 
            this.msktelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktelefone.Location = new System.Drawing.Point(725, 39);
            this.msktelefone.Mask = "(99) 99999-9999";
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(105, 21);
            this.msktelefone.TabIndex = 3;
            this.msktelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mudaEnter);
            // 
            // pnsuperior
            // 
            this.pnsuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(102)))), ((int)(((byte)(75)))));
            this.pnsuperior.Controls.Add(this.lblminimizar);
            this.pnsuperior.Controls.Add(this.lblfechar);
            this.pnsuperior.Controls.Add(this.pictureBox1);
            this.pnsuperior.Controls.Add(this.label1);
            this.pnsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnsuperior.Location = new System.Drawing.Point(0, 0);
            this.pnsuperior.Name = "pnsuperior";
            this.pnsuperior.Size = new System.Drawing.Size(973, 30);
            this.pnsuperior.TabIndex = 0;
            this.pnsuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnsuperior_MouseDown);
            this.pnsuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnsuperior_MouseMove);
            this.pnsuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnsuperior_MouseUp);
            // 
            // lblminimizar
            // 
            this.lblminimizar.AutoSize = true;
            this.lblminimizar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblminimizar.ForeColor = System.Drawing.Color.White;
            this.lblminimizar.Location = new System.Drawing.Point(921, 4);
            this.lblminimizar.Name = "lblminimizar";
            this.lblminimizar.Size = new System.Drawing.Size(19, 22);
            this.lblminimizar.TabIndex = 3;
            this.lblminimizar.Text = "_";
            this.lblminimizar.Click += new System.EventHandler(this.lblminimizar_Click);
            // 
            // lblfechar
            // 
            this.lblfechar.AutoSize = true;
            this.lblfechar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lblfechar.ForeColor = System.Drawing.Color.White;
            this.lblfechar.Location = new System.Drawing.Point(945, 5);
            this.lblfechar.Name = "lblfechar";
            this.lblfechar.Size = new System.Drawing.Size(20, 22);
            this.lblfechar.TabIndex = 2;
            this.lblfechar.Text = "X";
            this.lblfechar.Click += new System.EventHandler(this.lblfechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE CADASTRO DE CLIENTES";
            // 
            // frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 533);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmcliente_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnsuperior.ResumeLayout(false);
            this.pnsuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnsuperior;
        private System.Windows.Forms.Label lblminimizar;
        private System.Windows.Forms.Label lblfechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgdados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskcep;
        private System.Windows.Forms.MaskedTextBox msknasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msktelefone;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnovo;
        private System.Windows.Forms.Button btcarregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmunicipio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbairro;
    }
}

