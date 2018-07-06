namespace WindowsFormsApp2
{
    partial class dentista
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dentista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Especialidade2 = new System.Windows.Forms.ComboBox();
            this.Especialidade1 = new System.Windows.Forms.ComboBox();
            this.Email_Dentista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.Endereco_Dentista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Telefone_Dentista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Celular_Dentista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CPF_Dentista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.RG_Dentista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nome_Dentista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.Adicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Data = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Limpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Excluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Alterar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Consulta = new System.Windows.Forms.Panel();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.iddentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomedentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgdentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfdentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascdentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celdentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teldentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecodentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaildentistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dentistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_consultorioDataSet9 = new WindowsFormsApp2.tcc_consultorioDataSet9();
            this.dentistaTableAdapter = new WindowsFormsApp2.tcc_consultorioDataSet9TableAdapters.dentistaTableAdapter();
            this.panel2.SuspendLayout();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_consultorioDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.bunifuThinButton26);
            this.panel2.Controls.Add(this.bunifuThinButton25);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 45);
            this.panel2.TabIndex = 2;
            // 
            // bunifuThinButton26
            // 
            this.bunifuThinButton26.ActiveBorderThickness = 1;
            this.bunifuThinButton26.ActiveCornerRadius = 1;
            this.bunifuThinButton26.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton26.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton26.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton26.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton26.BackgroundImage")));
            this.bunifuThinButton26.ButtonText = "Consultar";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 1;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton26.Location = new System.Drawing.Point(111, 4);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(110, 41);
            this.bunifuThinButton26.TabIndex = 94;
            this.bunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton26.Click += new System.EventHandler(this.bunifuThinButton26_Click);
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 1;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Cadastar";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 1;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton25.Location = new System.Drawing.Point(0, 4);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(110, 41);
            this.bunifuThinButton25.TabIndex = 95;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(368, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 18);
            this.label11.TabIndex = 142;
            this.label11.Text = "2ª Especialidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(215, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 18);
            this.label10.TabIndex = 141;
            this.label10.Text = "1ª Especialidade";
            // 
            // Especialidade2
            // 
            this.Especialidade2.FormattingEnabled = true;
            this.Especialidade2.Items.AddRange(new object[] {
            "CIrurgião",
            "Dentista Pediátrico",
            "n sei"});
            this.Especialidade2.Location = new System.Drawing.Point(371, 320);
            this.Especialidade2.Name = "Especialidade2";
            this.Especialidade2.Size = new System.Drawing.Size(121, 21);
            this.Especialidade2.TabIndex = 140;
            // 
            // Especialidade1
            // 
            this.Especialidade1.FormattingEnabled = true;
            this.Especialidade1.Items.AddRange(new object[] {
            "CIrurgião",
            "Dentista Pediátrico",
            "n sei"});
            this.Especialidade1.Location = new System.Drawing.Point(218, 320);
            this.Especialidade1.Name = "Especialidade1";
            this.Especialidade1.Size = new System.Drawing.Size(121, 21);
            this.Especialidade1.TabIndex = 139;
            // 
            // Email_Dentista
            // 
            this.Email_Dentista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Dentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Email_Dentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_Dentista.HintForeColor = System.Drawing.Color.Empty;
            this.Email_Dentista.HintText = "";
            this.Email_Dentista.isPassword = true;
            this.Email_Dentista.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.Email_Dentista.LineIdleColor = System.Drawing.Color.Gray;
            this.Email_Dentista.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Email_Dentista.LineThickness = 3;
            this.Email_Dentista.Location = new System.Drawing.Point(18, 308);
            this.Email_Dentista.Margin = new System.Windows.Forms.Padding(4);
            this.Email_Dentista.Name = "Email_Dentista";
            this.Email_Dentista.Size = new System.Drawing.Size(167, 33);
            this.Email_Dentista.TabIndex = 138;
            this.Email_Dentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 137;
            this.label9.Text = "E-Mail";
            // 
            // Endereco_Dentista
            // 
            this.Endereco_Dentista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Endereco_Dentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Endereco_Dentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Endereco_Dentista.HintForeColor = System.Drawing.Color.Empty;
            this.Endereco_Dentista.HintText = "";
            this.Endereco_Dentista.isPassword = true;
            this.Endereco_Dentista.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.Endereco_Dentista.LineIdleColor = System.Drawing.Color.Gray;
            this.Endereco_Dentista.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Endereco_Dentista.LineThickness = 3;
            this.Endereco_Dentista.Location = new System.Drawing.Point(446, 217);
            this.Endereco_Dentista.Margin = new System.Windows.Forms.Padding(4);
            this.Endereco_Dentista.Name = "Endereco_Dentista";
            this.Endereco_Dentista.Size = new System.Drawing.Size(167, 33);
            this.Endereco_Dentista.TabIndex = 134;
            this.Endereco_Dentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 133;
            this.label7.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 131;
            this.label1.Text = "Data de Nascimento";
            // 
            // Telefone_Dentista
            // 
            this.Telefone_Dentista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Telefone_Dentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Telefone_Dentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Telefone_Dentista.HintForeColor = System.Drawing.Color.Empty;
            this.Telefone_Dentista.HintText = "";
            this.Telefone_Dentista.isPassword = true;
            this.Telefone_Dentista.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.Telefone_Dentista.LineIdleColor = System.Drawing.Color.Gray;
            this.Telefone_Dentista.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Telefone_Dentista.LineThickness = 3;
            this.Telefone_Dentista.Location = new System.Drawing.Point(256, 217);
            this.Telefone_Dentista.Margin = new System.Windows.Forms.Padding(4);
            this.Telefone_Dentista.Name = "Telefone_Dentista";
            this.Telefone_Dentista.Size = new System.Drawing.Size(167, 33);
            this.Telefone_Dentista.TabIndex = 130;
            this.Telefone_Dentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 129;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 128;
            this.label5.Text = "Celular";
            // 
            // Celular_Dentista
            // 
            this.Celular_Dentista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Celular_Dentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Celular_Dentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Celular_Dentista.HintForeColor = System.Drawing.Color.Empty;
            this.Celular_Dentista.HintText = "";
            this.Celular_Dentista.isPassword = false;
            this.Celular_Dentista.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.Celular_Dentista.LineIdleColor = System.Drawing.Color.Gray;
            this.Celular_Dentista.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Celular_Dentista.LineThickness = 3;
            this.Celular_Dentista.Location = new System.Drawing.Point(18, 217);
            this.Celular_Dentista.Margin = new System.Windows.Forms.Padding(4);
            this.Celular_Dentista.Name = "Celular_Dentista";
            this.Celular_Dentista.Size = new System.Drawing.Size(218, 34);
            this.Celular_Dentista.TabIndex = 127;
            this.Celular_Dentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CPF_Dentista
            // 
            this.CPF_Dentista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPF_Dentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CPF_Dentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPF_Dentista.HintForeColor = System.Drawing.Color.Empty;
            this.CPF_Dentista.HintText = "";
            this.CPF_Dentista.isPassword = false;
            this.CPF_Dentista.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.CPF_Dentista.LineIdleColor = System.Drawing.Color.Gray;
            this.CPF_Dentista.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.CPF_Dentista.LineThickness = 3;
            this.CPF_Dentista.Location = new System.Drawing.Point(552, 125);
            this.CPF_Dentista.Margin = new System.Windows.Forms.Padding(4);
            this.CPF_Dentista.Name = "CPF_Dentista";
            this.CPF_Dentista.Size = new System.Drawing.Size(167, 33);
            this.CPF_Dentista.TabIndex = 125;
            this.CPF_Dentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 124;
            this.label4.Text = "CPF";
            // 
            // RG_Dentista
            // 
            this.RG_Dentista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RG_Dentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RG_Dentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RG_Dentista.HintForeColor = System.Drawing.Color.Empty;
            this.RG_Dentista.HintText = "";
            this.RG_Dentista.isPassword = true;
            this.RG_Dentista.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.RG_Dentista.LineIdleColor = System.Drawing.Color.Gray;
            this.RG_Dentista.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.RG_Dentista.LineThickness = 3;
            this.RG_Dentista.Location = new System.Drawing.Point(371, 125);
            this.RG_Dentista.Margin = new System.Windows.Forms.Padding(4);
            this.RG_Dentista.Name = "RG_Dentista";
            this.RG_Dentista.Size = new System.Drawing.Size(167, 33);
            this.RG_Dentista.TabIndex = 123;
            this.RG_Dentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 122;
            this.label3.Text = "RG";
            // 
            // Nome_Dentista
            // 
            this.Nome_Dentista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nome_Dentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Nome_Dentista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nome_Dentista.HintForeColor = System.Drawing.Color.Empty;
            this.Nome_Dentista.HintText = "";
            this.Nome_Dentista.isPassword = false;
            this.Nome_Dentista.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.Nome_Dentista.LineIdleColor = System.Drawing.Color.Gray;
            this.Nome_Dentista.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Nome_Dentista.LineThickness = 3;
            this.Nome_Dentista.Location = new System.Drawing.Point(18, 125);
            this.Nome_Dentista.Margin = new System.Windows.Forms.Padding(4);
            this.Nome_Dentista.Name = "Nome_Dentista";
            this.Nome_Dentista.Size = new System.Drawing.Size(336, 33);
            this.Nome_Dentista.TabIndex = 121;
            this.Nome_Dentista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 120;
            this.label2.Text = "Nome";
            // 
            // Adicionar
            // 
            this.Adicionar.ActiveBorderThickness = 1;
            this.Adicionar.ActiveCornerRadius = 20;
            this.Adicionar.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Adicionar.ActiveForecolor = System.Drawing.Color.White;
            this.Adicionar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Adicionar.BackColor = System.Drawing.Color.White;
            this.Adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Adicionar.BackgroundImage")));
            this.Adicionar.ButtonText = "Adicionar";
            this.Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicionar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Adicionar.IdleBorderThickness = 1;
            this.Adicionar.IdleCornerRadius = 20;
            this.Adicionar.IdleFillColor = System.Drawing.Color.White;
            this.Adicionar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Adicionar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Adicionar.Location = new System.Drawing.Point(620, 512);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(5);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(110, 41);
            this.Adicionar.TabIndex = 126;
            this.Adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Adicionar.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // Data
            // 
            this.Data.BackColor = System.Drawing.Color.RoyalBlue;
            this.Data.BorderRadius = 0;
            this.Data.ForeColor = System.Drawing.Color.White;
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.FormatCustom = null;
            this.Data.Location = new System.Drawing.Point(736, 125);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(217, 36);
            this.Data.TabIndex = 143;
            this.Data.Value = new System.DateTime(2018, 6, 28, 7, 58, 31, 334);
            // 
            // Limpar
            // 
            this.Limpar.ActiveBorderThickness = 1;
            this.Limpar.ActiveCornerRadius = 20;
            this.Limpar.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Limpar.ActiveForecolor = System.Drawing.Color.White;
            this.Limpar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Limpar.BackColor = System.Drawing.Color.White;
            this.Limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Limpar.BackgroundImage")));
            this.Limpar.ButtonText = "Limpar";
            this.Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Limpar.IdleBorderThickness = 1;
            this.Limpar.IdleCornerRadius = 20;
            this.Limpar.IdleFillColor = System.Drawing.Color.White;
            this.Limpar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Limpar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Limpar.Location = new System.Drawing.Point(976, 512);
            this.Limpar.Margin = new System.Windows.Forms.Padding(5);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(110, 41);
            this.Limpar.TabIndex = 144;
            this.Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Limpar.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Excluir
            // 
            this.Excluir.ActiveBorderThickness = 1;
            this.Excluir.ActiveCornerRadius = 20;
            this.Excluir.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Excluir.ActiveForecolor = System.Drawing.Color.White;
            this.Excluir.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Excluir.BackColor = System.Drawing.Color.White;
            this.Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Excluir.BackgroundImage")));
            this.Excluir.ButtonText = "Excluir";
            this.Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Excluir.IdleBorderThickness = 1;
            this.Excluir.IdleCornerRadius = 20;
            this.Excluir.IdleFillColor = System.Drawing.Color.White;
            this.Excluir.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Excluir.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Excluir.Location = new System.Drawing.Point(860, 512);
            this.Excluir.Margin = new System.Windows.Forms.Padding(5);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(110, 41);
            this.Excluir.TabIndex = 145;
            this.Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alterar
            // 
            this.Alterar.ActiveBorderThickness = 1;
            this.Alterar.ActiveCornerRadius = 20;
            this.Alterar.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.Alterar.ActiveForecolor = System.Drawing.Color.White;
            this.Alterar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.Alterar.BackColor = System.Drawing.Color.White;
            this.Alterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Alterar.BackgroundImage")));
            this.Alterar.ButtonText = "Alterar";
            this.Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alterar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Alterar.IdleBorderThickness = 1;
            this.Alterar.IdleCornerRadius = 20;
            this.Alterar.IdleFillColor = System.Drawing.Color.White;
            this.Alterar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.Alterar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.Alterar.Location = new System.Drawing.Point(740, 512);
            this.Alterar.Margin = new System.Windows.Forms.Padding(5);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(110, 41);
            this.Alterar.TabIndex = 146;
            this.Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.textBox1);
            this.Consulta.Controls.Add(this.bunifuCustomDataGrid1);
            this.Consulta.Location = new System.Drawing.Point(0, 45);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(1091, 577);
            this.Consulta.TabIndex = 147;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.HintForeColor = System.Drawing.Color.Empty;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.textBox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(178, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(733, 33);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.OnValueChanged += new System.EventHandler(this.textBox1_OnValueChanged);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddentistaDataGridViewTextBoxColumn,
            this.nomedentistaDataGridViewTextBoxColumn,
            this.rgdentistaDataGridViewTextBoxColumn,
            this.cpfdentistaDataGridViewTextBoxColumn,
            this.nascdentistaDataGridViewTextBoxColumn,
            this.celdentistaDataGridViewTextBoxColumn,
            this.teldentistaDataGridViewTextBoxColumn,
            this.enderecodentistaDataGridViewTextBoxColumn,
            this.emaildentistaDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn1});
            this.bunifuCustomDataGrid1.DataSource = this.dentistaBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(22, 68);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1033, 432);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // iddentistaDataGridViewTextBoxColumn
            // 
            this.iddentistaDataGridViewTextBoxColumn.DataPropertyName = "id_dentista";
            this.iddentistaDataGridViewTextBoxColumn.HeaderText = "id_dentista";
            this.iddentistaDataGridViewTextBoxColumn.Name = "iddentistaDataGridViewTextBoxColumn";
            // 
            // nomedentistaDataGridViewTextBoxColumn
            // 
            this.nomedentistaDataGridViewTextBoxColumn.DataPropertyName = "nome_dentista";
            this.nomedentistaDataGridViewTextBoxColumn.HeaderText = "nome_dentista";
            this.nomedentistaDataGridViewTextBoxColumn.Name = "nomedentistaDataGridViewTextBoxColumn";
            // 
            // rgdentistaDataGridViewTextBoxColumn
            // 
            this.rgdentistaDataGridViewTextBoxColumn.DataPropertyName = "rg_dentista";
            this.rgdentistaDataGridViewTextBoxColumn.HeaderText = "rg_dentista";
            this.rgdentistaDataGridViewTextBoxColumn.Name = "rgdentistaDataGridViewTextBoxColumn";
            // 
            // cpfdentistaDataGridViewTextBoxColumn
            // 
            this.cpfdentistaDataGridViewTextBoxColumn.DataPropertyName = "cpf_dentista";
            this.cpfdentistaDataGridViewTextBoxColumn.HeaderText = "cpf_dentista";
            this.cpfdentistaDataGridViewTextBoxColumn.Name = "cpfdentistaDataGridViewTextBoxColumn";
            // 
            // nascdentistaDataGridViewTextBoxColumn
            // 
            this.nascdentistaDataGridViewTextBoxColumn.DataPropertyName = "nasc_dentista";
            this.nascdentistaDataGridViewTextBoxColumn.HeaderText = "nasc_dentista";
            this.nascdentistaDataGridViewTextBoxColumn.Name = "nascdentistaDataGridViewTextBoxColumn";
            // 
            // celdentistaDataGridViewTextBoxColumn
            // 
            this.celdentistaDataGridViewTextBoxColumn.DataPropertyName = "cel_dentista";
            this.celdentistaDataGridViewTextBoxColumn.HeaderText = "cel_dentista";
            this.celdentistaDataGridViewTextBoxColumn.Name = "celdentistaDataGridViewTextBoxColumn";
            // 
            // teldentistaDataGridViewTextBoxColumn
            // 
            this.teldentistaDataGridViewTextBoxColumn.DataPropertyName = "tel_dentista";
            this.teldentistaDataGridViewTextBoxColumn.HeaderText = "tel_dentista";
            this.teldentistaDataGridViewTextBoxColumn.Name = "teldentistaDataGridViewTextBoxColumn";
            // 
            // enderecodentistaDataGridViewTextBoxColumn
            // 
            this.enderecodentistaDataGridViewTextBoxColumn.DataPropertyName = "endereco_dentista";
            this.enderecodentistaDataGridViewTextBoxColumn.HeaderText = "endereco_dentista";
            this.enderecodentistaDataGridViewTextBoxColumn.Name = "enderecodentistaDataGridViewTextBoxColumn";
            // 
            // emaildentistaDataGridViewTextBoxColumn
            // 
            this.emaildentistaDataGridViewTextBoxColumn.DataPropertyName = "email_dentista";
            this.emaildentistaDataGridViewTextBoxColumn.HeaderText = "email_dentista";
            this.emaildentistaDataGridViewTextBoxColumn.Name = "emaildentistaDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "1area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "1area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn1
            // 
            this.areaDataGridViewTextBoxColumn1.DataPropertyName = "2area";
            this.areaDataGridViewTextBoxColumn1.HeaderText = "2area";
            this.areaDataGridViewTextBoxColumn1.Name = "areaDataGridViewTextBoxColumn1";
            // 
            // dentistaBindingSource
            // 
            this.dentistaBindingSource.DataMember = "dentista";
            this.dentistaBindingSource.DataSource = this.tcc_consultorioDataSet9;
            // 
            // tcc_consultorioDataSet9
            // 
            this.tcc_consultorioDataSet9.DataSetName = "tcc_consultorioDataSet9";
            this.tcc_consultorioDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dentistaTableAdapter
            // 
            this.dentistaTableAdapter.ClearBeforeFill = true;
            // 
            // dentista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Especialidade2);
            this.Controls.Add(this.Especialidade1);
            this.Controls.Add(this.Email_Dentista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Endereco_Dentista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Telefone_Dentista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Celular_Dentista);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.CPF_Dentista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RG_Dentista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome_Dentista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "dentista";
            this.Size = new System.Drawing.Size(1120, 639);
            this.panel2.ResumeLayout(false);
            this.Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_consultorioDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Especialidade2;
        private System.Windows.Forms.ComboBox Especialidade1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email_Dentista;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Endereco_Dentista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Telefone_Dentista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Celular_Dentista;
        private Bunifu.Framework.UI.BunifuThinButton2 Adicionar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CPF_Dentista;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RG_Dentista;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Nome_Dentista;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker Data;
        private Bunifu.Framework.UI.BunifuThinButton2 Limpar;
        private Bunifu.Framework.UI.BunifuThinButton2 Excluir;
        private Bunifu.Framework.UI.BunifuThinButton2 Alterar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private System.Windows.Forms.Panel Consulta;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomedentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgdentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfdentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascdentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celdentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teldentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecodentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaildentistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource dentistaBindingSource;
        private tcc_consultorioDataSet9 tcc_consultorioDataSet9;
        private tcc_consultorioDataSet9TableAdapters.dentistaTableAdapter dentistaTableAdapter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
    }
}
