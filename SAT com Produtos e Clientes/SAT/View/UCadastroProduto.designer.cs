namespace NFCe.View
{
	partial class FCadastroProduto
    {
		private System.Windows.Forms.PictureBox Image1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView GridPrincipal;
		private System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button SpeedButton1;
		// Required designer variable.
		private System.ComponentModel.IContainer components = null;

		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label2 = new System.Windows.Forms.Label();
            this.GridPrincipal = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.EditLocaliza = new System.Windows.Forms.TextBox();
            this.SpeedButton1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCodigoInterno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNCM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxIPPT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxIAT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGtin = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_VALOR_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_QTD_ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_IPPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_IAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_ECF_ICMS_ST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_CODIGO_INTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_ESTOQUE_MIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPrincipal_ESTOQUE_MAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrincipal)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(68, 320);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 13);
            this.Label2.TabIndex = 1;
            // 
            // GridPrincipal
            // 
            this.GridPrincipal.AllowUserToAddRows = false;
            this.GridPrincipal.AllowUserToDeleteRows = false;
            this.GridPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.GTIN,
            this.GridPrincipal_NOME,
            this.GridPrincipal_VALOR_VENDA,
            this.GridPrincipal_QTD_ESTOQUE,
            this.GridPrincipal_IPPT,
            this.GridPrincipal_IAT,
            this.GridPrincipal_ECF_ICMS_ST,
            this.GridPrincipal_CODIGO_INTERNO,
            this.GridPrincipal_ESTOQUE_MIN,
            this.GridPrincipal_ESTOQUE_MAX});
            this.GridPrincipal.Font = new System.Drawing.Font("Tahoma", 8F);
            this.GridPrincipal.Location = new System.Drawing.Point(68, 133);
            this.GridPrincipal.Name = "GridPrincipal";
            this.GridPrincipal.ReadOnly = true;
            this.GridPrincipal.Size = new System.Drawing.Size(613, 215);
            this.GridPrincipal.TabIndex = 1;
            this.GridPrincipal.Text = "Select columns";
            this.GridPrincipal.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPrincipal_CellEnter);
            this.GridPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridPrincipal_KeyDown);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Panel1.Controls.Add(this.EditLocaliza);
            this.Panel1.Controls.Add(this.SpeedButton1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(68, 354);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(613, 58);
            this.Panel1.TabIndex = 0;
            // 
            // EditLocaliza
            // 
            this.EditLocaliza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EditLocaliza.Location = new System.Drawing.Point(10, 27);
            this.EditLocaliza.Name = "EditLocaliza";
            this.EditLocaliza.Size = new System.Drawing.Size(485, 20);
            this.EditLocaliza.TabIndex = 0;
            // 
            // SpeedButton1
            // 
            this.SpeedButton1.BackColor = System.Drawing.Color.White;
            this.SpeedButton1.Location = new System.Drawing.Point(497, 27);
            this.SpeedButton1.Name = "SpeedButton1";
            this.SpeedButton1.Size = new System.Drawing.Size(105, 21);
            this.SpeedButton1.TabIndex = 5;
            this.SpeedButton1.Text = "Localiza (F2)";
            this.SpeedButton1.UseVisualStyleBackColor = false;
            this.SpeedButton1.Click += new System.EventHandler(this.SpeedButton1_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(7, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Procura por:";
            // 
            // botaoCancela
            // 
            this.botaoCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancela.Font = new System.Drawing.Font("Tahoma", 8F);
            this.botaoCancela.ForeColor = System.Drawing.Color.Black;
            this.botaoCancela.Image = global::NFCe.Properties.Resources.cancelar16;
            this.botaoCancela.Location = new System.Drawing.Point(561, 424);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(120, 25);
            this.botaoCancela.TabIndex = 4;
            this.botaoCancela.Text = "Sair (ESC)";
            this.botaoCancela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoCancela.Click += new System.EventHandler(this.botaoCancela_Click);
            // 
            // Image1
            // 
            this.Image1.Image = global::NFCe.Properties.Resources.telaMesclar01;
            this.Image1.Location = new System.Drawing.Point(10, 10);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(48, 48);
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxCodigoInterno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxNCM);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxIPPT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxIAT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxValorUnitario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGtin);
            this.groupBox1.Location = new System.Drawing.Point(68, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Produto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Código Interno:";
            // 
            // textBoxCodigoInterno
            // 
            this.textBoxCodigoInterno.Location = new System.Drawing.Point(386, 82);
            this.textBoxCodigoInterno.Name = "textBoxCodigoInterno";
            this.textBoxCodigoInterno.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoInterno.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "NCM:";
            // 
            // textBoxNCM
            // 
            this.textBoxNCM.Location = new System.Drawing.Point(493, 82);
            this.textBoxNCM.Name = "textBoxNCM";
            this.textBoxNCM.Size = new System.Drawing.Size(110, 20);
            this.textBoxNCM.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "IPPT:";
            // 
            // comboBoxIPPT
            // 
            this.comboBoxIPPT.FormattingEnabled = true;
            this.comboBoxIPPT.Items.AddRange(new object[] {
            "Próprio",
            "Terceirizado"});
            this.comboBoxIPPT.Location = new System.Drawing.Point(259, 82);
            this.comboBoxIPPT.Name = "comboBoxIPPT";
            this.comboBoxIPPT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIPPT.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "IAT:";
            // 
            // comboBoxIAT
            // 
            this.comboBoxIAT.FormattingEnabled = true;
            this.comboBoxIAT.Items.AddRange(new object[] {
            "Arredondamento",
            "Truncamento"});
            this.comboBoxIAT.Location = new System.Drawing.Point(132, 83);
            this.comboBoxIAT.Name = "comboBoxIAT";
            this.comboBoxIAT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIAT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valor Unitário:";
            // 
            // textBoxValorUnitario
            // 
            this.textBoxValorUnitario.Location = new System.Drawing.Point(10, 83);
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            this.textBoxValorUnitario.Size = new System.Drawing.Size(116, 20);
            this.textBoxValorUnitario.TabIndex = 6;
            this.textBoxValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(132, 37);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(470, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "GTIN:";
            // 
            // textBoxGtin
            // 
            this.textBoxGtin.Location = new System.Drawing.Point(10, 37);
            this.textBoxGtin.Name = "textBoxGtin";
            this.textBoxGtin.Size = new System.Drawing.Size(116, 20);
            this.textBoxGtin.TabIndex = 0;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonInserir.ForeColor = System.Drawing.Color.Black;
            this.buttonInserir.Image = global::NFCe.Properties.Resources.arrowright_green16;
            this.buttonInserir.Location = new System.Drawing.Point(68, 424);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(98, 25);
            this.buttonInserir.TabIndex = 6;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonAlterar.ForeColor = System.Drawing.Color.Black;
            this.buttonAlterar.Image = global::NFCe.Properties.Resources.arrowleft_green16;
            this.buttonAlterar.Location = new System.Drawing.Point(172, 424);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(98, 25);
            this.buttonAlterar.TabIndex = 7;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // GTIN
            // 
            this.GTIN.DataPropertyName = "GTIN";
            this.GTIN.HeaderText = "GTIN";
            this.GTIN.Name = "GTIN";
            this.GTIN.ReadOnly = true;
            this.GTIN.Width = 110;
            // 
            // GridPrincipal_NOME
            // 
            this.GridPrincipal_NOME.DataPropertyName = "Nome";
            this.GridPrincipal_NOME.HeaderText = "Descrição da Mercadoria ou Serviço";
            this.GridPrincipal_NOME.Name = "GridPrincipal_NOME";
            this.GridPrincipal_NOME.ReadOnly = true;
            this.GridPrincipal_NOME.Width = 300;
            // 
            // GridPrincipal_VALOR_VENDA
            // 
            this.GridPrincipal_VALOR_VENDA.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GridPrincipal_VALOR_VENDA.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridPrincipal_VALOR_VENDA.HeaderText = "Valor Unitário";
            this.GridPrincipal_VALOR_VENDA.Name = "GridPrincipal_VALOR_VENDA";
            this.GridPrincipal_VALOR_VENDA.ReadOnly = true;
            // 
            // GridPrincipal_QTD_ESTOQUE
            // 
            this.GridPrincipal_QTD_ESTOQUE.DataPropertyName = "QtdeEstoque";
            this.GridPrincipal_QTD_ESTOQUE.HeaderText = "Qtde. Estoque";
            this.GridPrincipal_QTD_ESTOQUE.Name = "GridPrincipal_QTD_ESTOQUE";
            this.GridPrincipal_QTD_ESTOQUE.ReadOnly = true;
            // 
            // GridPrincipal_IPPT
            // 
            this.GridPrincipal_IPPT.DataPropertyName = "IPPT";
            this.GridPrincipal_IPPT.HeaderText = "IPPT";
            this.GridPrincipal_IPPT.Name = "GridPrincipal_IPPT";
            this.GridPrincipal_IPPT.ReadOnly = true;
            // 
            // GridPrincipal_IAT
            // 
            this.GridPrincipal_IAT.DataPropertyName = "IAT";
            this.GridPrincipal_IAT.HeaderText = "IAT";
            this.GridPrincipal_IAT.Name = "GridPrincipal_IAT";
            this.GridPrincipal_IAT.ReadOnly = true;
            // 
            // GridPrincipal_ECF_ICMS_ST
            // 
            this.GridPrincipal_ECF_ICMS_ST.DataPropertyName = "NCM";
            this.GridPrincipal_ECF_ICMS_ST.HeaderText = "NCM";
            this.GridPrincipal_ECF_ICMS_ST.Name = "GridPrincipal_ECF_ICMS_ST";
            this.GridPrincipal_ECF_ICMS_ST.ReadOnly = true;
            // 
            // GridPrincipal_CODIGO_INTERNO
            // 
            this.GridPrincipal_CODIGO_INTERNO.DataPropertyName = "CodigoInterno";
            this.GridPrincipal_CODIGO_INTERNO.HeaderText = "Código Interno";
            this.GridPrincipal_CODIGO_INTERNO.Name = "GridPrincipal_CODIGO_INTERNO";
            this.GridPrincipal_CODIGO_INTERNO.ReadOnly = true;
            // 
            // GridPrincipal_ESTOQUE_MIN
            // 
            this.GridPrincipal_ESTOQUE_MIN.DataPropertyName = "EstoqueMinimo";
            this.GridPrincipal_ESTOQUE_MIN.HeaderText = "Estoque Mínimo";
            this.GridPrincipal_ESTOQUE_MIN.Name = "GridPrincipal_ESTOQUE_MIN";
            this.GridPrincipal_ESTOQUE_MIN.ReadOnly = true;
            // 
            // GridPrincipal_ESTOQUE_MAX
            // 
            this.GridPrincipal_ESTOQUE_MAX.DataPropertyName = "EstoqueMaximo";
            this.GridPrincipal_ESTOQUE_MAX.HeaderText = "Estoque Máximo";
            this.GridPrincipal_ESTOQUE_MAX.Name = "GridPrincipal_ESTOQUE_MAX";
            this.GridPrincipal_ESTOQUE_MAX.ReadOnly = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(577, 11);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(26, 20);
            this.textBoxId.TabIndex = 17;
            this.textBoxId.Visible = false;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Tahoma", 8F);
            this.buttonExcluir.ForeColor = System.Drawing.Color.Black;
            this.buttonExcluir.Image = global::NFCe.Properties.Resources.confirmar16;
            this.buttonExcluir.Location = new System.Drawing.Point(276, 424);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(98, 25);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // FCadastroProduto
            // 
            this.ClientSize = new System.Drawing.Size(692, 461);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GridPrincipal);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(226, 359);
            this.Name = "FCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FImportaProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridPrincipal)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private System.Windows.Forms.Button botaoCancela;
        public System.Windows.Forms.TextBox EditLocaliza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGtin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxValorUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxIPPT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxIAT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCodigoInterno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNCM;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_VALOR_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_QTD_ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_IPPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_IAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_ECF_ICMS_ST;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_CODIGO_INTERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_ESTOQUE_MIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridPrincipal_ESTOQUE_MAX;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonExcluir;

	}
}
