namespace WindowsFormsApp2
{
    partial class Tratamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tratamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_consultorioDataSet = new WindowsFormsApp2.tcc_consultorioDataSet();
            this.pacienteTableAdapter = new WindowsFormsApp2.tcc_consultorioDataSetTableAdapters.pacienteTableAdapter();
            this.tratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcc_consultorioDataSet3 = new WindowsFormsApp2.tcc_consultorioDataSet3();
            this.tratamentoTableAdapter = new WindowsFormsApp2.tcc_consultorioDataSet3TableAdapters.tratamentoTableAdapter();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nomepaciente = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.iDTratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPacienteTratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descricaotratamento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.precotratamento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.dentesregiao = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.nometratamento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iniciotermino = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.plano = new System.Windows.Forms.ComboBox();
            this.adicionartratamento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.alterartratamento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.excluirtratamento = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomepacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecopacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estcivilpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissaopacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotacoespacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_consultorioDataSet3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.tcc_consultorioDataSet;
            // 
            // tcc_consultorioDataSet
            // 
            this.tcc_consultorioDataSet.DataSetName = "tcc_consultorioDataSet";
            this.tcc_consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tratamentoBindingSource
            // 
            this.tratamentoBindingSource.DataMember = "tratamento";
            this.tratamentoBindingSource.DataSource = this.tcc_consultorioDataSet3;
            // 
            // tcc_consultorioDataSet3
            // 
            this.tcc_consultorioDataSet3.DataSetName = "tcc_consultorioDataSet3";
            this.tcc_consultorioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tratamentoTableAdapter
            // 
            this.tratamentoTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 13);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(173, 18);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Tratamentos Existentes -";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel6.Controls.Add(this.nomepaciente);
            this.panel6.Controls.Add(this.bunifuCustomLabel2);
            this.panel6.Location = new System.Drawing.Point(0, 346);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1091, 43);
            this.panel6.TabIndex = 108;
            // 
            // nomepaciente
            // 
            this.nomepaciente.AutoSize = true;
            this.nomepaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomepaciente.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nomepaciente.Location = new System.Drawing.Point(179, 13);
            this.nomepaciente.Name = "nomepaciente";
            this.nomepaciente.Size = new System.Drawing.Size(21, 18);
            this.nomepaciente.TabIndex = 1;
            this.nomepaciente.Text = ": )";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTratamentoDataGridViewTextBoxColumn,
            this.iDPacienteTratamentoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dentesDataGridViewTextBoxColumn,
            this.inicioDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.planoDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.tratamentoBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(111, 404);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(842, 156);
            this.bunifuCustomDataGrid1.TabIndex = 112;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // iDTratamentoDataGridViewTextBoxColumn
            // 
            this.iDTratamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Tratamento";
            this.iDTratamentoDataGridViewTextBoxColumn.HeaderText = "ID_Tratamento";
            this.iDTratamentoDataGridViewTextBoxColumn.Name = "iDTratamentoDataGridViewTextBoxColumn";
            this.iDTratamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPacienteTratamentoDataGridViewTextBoxColumn
            // 
            this.iDPacienteTratamentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Paciente_Tratamento";
            this.iDPacienteTratamentoDataGridViewTextBoxColumn.HeaderText = "ID_Paciente_Tratamento";
            this.iDPacienteTratamentoDataGridViewTextBoxColumn.Name = "iDPacienteTratamentoDataGridViewTextBoxColumn";
            this.iDPacienteTratamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dentesDataGridViewTextBoxColumn
            // 
            this.dentesDataGridViewTextBoxColumn.DataPropertyName = "Dentes";
            this.dentesDataGridViewTextBoxColumn.HeaderText = "Dentes";
            this.dentesDataGridViewTextBoxColumn.Name = "dentesDataGridViewTextBoxColumn";
            this.dentesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inicioDataGridViewTextBoxColumn
            // 
            this.inicioDataGridViewTextBoxColumn.DataPropertyName = "Inicio";
            this.inicioDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.inicioDataGridViewTextBoxColumn.Name = "inicioDataGridViewTextBoxColumn";
            this.inicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planoDataGridViewTextBoxColumn
            // 
            this.planoDataGridViewTextBoxColumn.DataPropertyName = "Plano";
            this.planoDataGridViewTextBoxColumn.HeaderText = "Plano";
            this.planoDataGridViewTextBoxColumn.Name = "planoDataGridViewTextBoxColumn";
            this.planoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(772, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 124;
            this.label6.Text = "Início/Término";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 123;
            this.label5.Text = "Histórico da Consulta";
            // 
            // descricaotratamento
            // 
            this.descricaotratamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descricaotratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.descricaotratamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descricaotratamento.HintForeColor = System.Drawing.Color.Empty;
            this.descricaotratamento.HintText = "";
            this.descricaotratamento.isPassword = false;
            this.descricaotratamento.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.descricaotratamento.LineIdleColor = System.Drawing.Color.Gray;
            this.descricaotratamento.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.descricaotratamento.LineThickness = 3;
            this.descricaotratamento.Location = new System.Drawing.Point(16, 202);
            this.descricaotratamento.Margin = new System.Windows.Forms.Padding(4);
            this.descricaotratamento.Name = "descricaotratamento";
            this.descricaotratamento.Size = new System.Drawing.Size(671, 122);
            this.descricaotratamento.TabIndex = 122;
            this.descricaotratamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // precotratamento
            // 
            this.precotratamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.precotratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.precotratamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.precotratamento.HintForeColor = System.Drawing.Color.Empty;
            this.precotratamento.HintText = "";
            this.precotratamento.isPassword = false;
            this.precotratamento.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.precotratamento.LineIdleColor = System.Drawing.Color.Gray;
            this.precotratamento.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.precotratamento.LineThickness = 3;
            this.precotratamento.Location = new System.Drawing.Point(775, 93);
            this.precotratamento.Margin = new System.Windows.Forms.Padding(4);
            this.precotratamento.Name = "precotratamento";
            this.precotratamento.Size = new System.Drawing.Size(167, 33);
            this.precotratamento.TabIndex = 120;
            this.precotratamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(772, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 119;
            this.label4.Text = "Preço";
            // 
            // dentesregiao
            // 
            this.dentesregiao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dentesregiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dentesregiao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dentesregiao.HintForeColor = System.Drawing.Color.Empty;
            this.dentesregiao.HintText = "";
            this.dentesregiao.isPassword = true;
            this.dentesregiao.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.dentesregiao.LineIdleColor = System.Drawing.Color.Gray;
            this.dentesregiao.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.dentesregiao.LineThickness = 3;
            this.dentesregiao.Location = new System.Drawing.Point(555, 93);
            this.dentesregiao.Margin = new System.Windows.Forms.Padding(4);
            this.dentesregiao.Name = "dentesregiao";
            this.dentesregiao.Size = new System.Drawing.Size(167, 33);
            this.dentesregiao.TabIndex = 118;
            this.dentesregiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 117;
            this.label3.Text = "Dentes/Região";
            // 
            // nometratamento
            // 
            this.nometratamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nometratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nometratamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nometratamento.HintForeColor = System.Drawing.Color.Empty;
            this.nometratamento.HintText = "";
            this.nometratamento.isPassword = false;
            this.nometratamento.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.nometratamento.LineIdleColor = System.Drawing.Color.Gray;
            this.nometratamento.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.nometratamento.LineThickness = 3;
            this.nometratamento.Location = new System.Drawing.Point(168, 93);
            this.nometratamento.Margin = new System.Windows.Forms.Padding(4);
            this.nometratamento.Name = "nometratamento";
            this.nometratamento.Size = new System.Drawing.Size(336, 33);
            this.nometratamento.TabIndex = 116;
            this.nometratamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 114;
            this.label2.Text = "Tratamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 113;
            this.label1.Text = "Plano";
            // 
            // iniciotermino
            // 
            this.iniciotermino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iniciotermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.iniciotermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iniciotermino.HintForeColor = System.Drawing.Color.Empty;
            this.iniciotermino.HintText = "";
            this.iniciotermino.isPassword = true;
            this.iniciotermino.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.iniciotermino.LineIdleColor = System.Drawing.Color.Gray;
            this.iniciotermino.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.iniciotermino.LineThickness = 3;
            this.iniciotermino.Location = new System.Drawing.Point(775, 180);
            this.iniciotermino.Margin = new System.Windows.Forms.Padding(4);
            this.iniciotermino.Name = "iniciotermino";
            this.iniciotermino.Size = new System.Drawing.Size(167, 33);
            this.iniciotermino.TabIndex = 125;
            this.iniciotermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.bunifuThinButton26);
            this.panel1.Controls.Add(this.bunifuThinButton25);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 45);
            this.panel1.TabIndex = 109;
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
            this.bunifuThinButton26.ButtonText = "Tratamentos";
            this.bunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton26.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleBorderThickness = 1;
            this.bunifuThinButton26.IdleCornerRadius = 1;
            this.bunifuThinButton26.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton26.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton26.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton26.Location = new System.Drawing.Point(0, -1);
            this.bunifuThinButton26.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton26.Name = "bunifuThinButton26";
            this.bunifuThinButton26.Size = new System.Drawing.Size(110, 46);
            this.bunifuThinButton26.TabIndex = 128;
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
            this.bunifuThinButton25.ButtonText = "Pacientes";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 1;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton25.Location = new System.Drawing.Point(111, -1);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(110, 46);
            this.bunifuThinButton25.TabIndex = 129;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // plano
            // 
            this.plano.FormattingEnabled = true;
            this.plano.Items.AddRange(new object[] {
            "Particular",
            "Uniodonto",
            "Sulamerica",
            "Bradesco Dental"});
            this.plano.Location = new System.Drawing.Point(20, 105);
            this.plano.Name = "plano";
            this.plano.Size = new System.Drawing.Size(118, 21);
            this.plano.TabIndex = 128;
            // 
            // adicionartratamento
            // 
            this.adicionartratamento.ActiveBorderThickness = 1;
            this.adicionartratamento.ActiveCornerRadius = 20;
            this.adicionartratamento.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.adicionartratamento.ActiveForecolor = System.Drawing.Color.White;
            this.adicionartratamento.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.adicionartratamento.BackColor = System.Drawing.Color.White;
            this.adicionartratamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicionartratamento.BackgroundImage")));
            this.adicionartratamento.ButtonText = "Adicionar";
            this.adicionartratamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adicionartratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionartratamento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.adicionartratamento.IdleBorderThickness = 1;
            this.adicionartratamento.IdleCornerRadius = 20;
            this.adicionartratamento.IdleFillColor = System.Drawing.Color.White;
            this.adicionartratamento.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.adicionartratamento.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.adicionartratamento.Location = new System.Drawing.Point(959, 283);
            this.adicionartratamento.Margin = new System.Windows.Forms.Padding(5);
            this.adicionartratamento.Name = "adicionartratamento";
            this.adicionartratamento.Size = new System.Drawing.Size(110, 41);
            this.adicionartratamento.TabIndex = 127;
            this.adicionartratamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adicionartratamento.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // alterartratamento
            // 
            this.alterartratamento.ActiveBorderThickness = 1;
            this.alterartratamento.ActiveCornerRadius = 20;
            this.alterartratamento.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.alterartratamento.ActiveForecolor = System.Drawing.Color.White;
            this.alterartratamento.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.alterartratamento.BackColor = System.Drawing.Color.White;
            this.alterartratamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alterartratamento.BackgroundImage")));
            this.alterartratamento.ButtonText = "Alterar";
            this.alterartratamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterartratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterartratamento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.alterartratamento.IdleBorderThickness = 1;
            this.alterartratamento.IdleCornerRadius = 20;
            this.alterartratamento.IdleFillColor = System.Drawing.Color.White;
            this.alterartratamento.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.alterartratamento.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.alterartratamento.Location = new System.Drawing.Point(839, 283);
            this.alterartratamento.Margin = new System.Windows.Forms.Padding(5);
            this.alterartratamento.Name = "alterartratamento";
            this.alterartratamento.Size = new System.Drawing.Size(110, 41);
            this.alterartratamento.TabIndex = 126;
            this.alterartratamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alterartratamento.Click += new System.EventHandler(this.alterartratamento_Click);
            // 
            // excluirtratamento
            // 
            this.excluirtratamento.ActiveBorderThickness = 1;
            this.excluirtratamento.ActiveCornerRadius = 20;
            this.excluirtratamento.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.excluirtratamento.ActiveForecolor = System.Drawing.Color.White;
            this.excluirtratamento.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.excluirtratamento.BackColor = System.Drawing.Color.White;
            this.excluirtratamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excluirtratamento.BackgroundImage")));
            this.excluirtratamento.ButtonText = "Excluir";
            this.excluirtratamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirtratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirtratamento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.excluirtratamento.IdleBorderThickness = 1;
            this.excluirtratamento.IdleCornerRadius = 20;
            this.excluirtratamento.IdleFillColor = System.Drawing.Color.White;
            this.excluirtratamento.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.excluirtratamento.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.excluirtratamento.Location = new System.Drawing.Point(719, 283);
            this.excluirtratamento.Margin = new System.Windows.Forms.Padding(5);
            this.excluirtratamento.Name = "excluirtratamento";
            this.excluirtratamento.Size = new System.Drawing.Size(110, 41);
            this.excluirtratamento.TabIndex = 121;
            this.excluirtratamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.excluirtratamento.Click += new System.EventHandler(this.bunifuThinButton23_Click_1);
            // 
            // bunifuCustomDataGrid2
            // 
            this.bunifuCustomDataGrid2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpacienteDataGridViewTextBoxColumn,
            this.nomepacienteDataGridViewTextBoxColumn,
            this.rgpacienteDataGridViewTextBoxColumn,
            this.cpfpacienteDataGridViewTextBoxColumn,
            this.nascpacienteDataGridViewTextBoxColumn,
            this.celpacienteDataGridViewTextBoxColumn,
            this.telpacienteDataGridViewTextBoxColumn,
            this.enderecopacienteDataGridViewTextBoxColumn,
            this.emailpacienteDataGridViewTextBoxColumn,
            this.estcivilpacienteDataGridViewTextBoxColumn,
            this.profissaopacienteDataGridViewTextBoxColumn,
            this.anotacoespacienteDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid2.DataSource = this.pacienteBindingSource;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(21, 26);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.ReadOnly = true;
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1047, 472);
            this.bunifuCustomDataGrid2.TabIndex = 23;
            this.bunifuCustomDataGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid3_CellContentClick);
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            this.idpacienteDataGridViewTextBoxColumn.DataPropertyName = "id_paciente";
            this.idpacienteDataGridViewTextBoxColumn.HeaderText = "id_paciente";
            this.idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            this.idpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomepacienteDataGridViewTextBoxColumn
            // 
            this.nomepacienteDataGridViewTextBoxColumn.DataPropertyName = "nome_paciente";
            this.nomepacienteDataGridViewTextBoxColumn.HeaderText = "nome_paciente";
            this.nomepacienteDataGridViewTextBoxColumn.Name = "nomepacienteDataGridViewTextBoxColumn";
            this.nomepacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgpacienteDataGridViewTextBoxColumn
            // 
            this.rgpacienteDataGridViewTextBoxColumn.DataPropertyName = "rg_paciente";
            this.rgpacienteDataGridViewTextBoxColumn.HeaderText = "rg_paciente";
            this.rgpacienteDataGridViewTextBoxColumn.Name = "rgpacienteDataGridViewTextBoxColumn";
            this.rgpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfpacienteDataGridViewTextBoxColumn
            // 
            this.cpfpacienteDataGridViewTextBoxColumn.DataPropertyName = "cpf_paciente";
            this.cpfpacienteDataGridViewTextBoxColumn.HeaderText = "cpf_paciente";
            this.cpfpacienteDataGridViewTextBoxColumn.Name = "cpfpacienteDataGridViewTextBoxColumn";
            this.cpfpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascpacienteDataGridViewTextBoxColumn
            // 
            this.nascpacienteDataGridViewTextBoxColumn.DataPropertyName = "nasc_paciente";
            this.nascpacienteDataGridViewTextBoxColumn.HeaderText = "nasc_paciente";
            this.nascpacienteDataGridViewTextBoxColumn.Name = "nascpacienteDataGridViewTextBoxColumn";
            this.nascpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celpacienteDataGridViewTextBoxColumn
            // 
            this.celpacienteDataGridViewTextBoxColumn.DataPropertyName = "cel_paciente";
            this.celpacienteDataGridViewTextBoxColumn.HeaderText = "cel_paciente";
            this.celpacienteDataGridViewTextBoxColumn.Name = "celpacienteDataGridViewTextBoxColumn";
            this.celpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telpacienteDataGridViewTextBoxColumn
            // 
            this.telpacienteDataGridViewTextBoxColumn.DataPropertyName = "tel_paciente";
            this.telpacienteDataGridViewTextBoxColumn.HeaderText = "tel_paciente";
            this.telpacienteDataGridViewTextBoxColumn.Name = "telpacienteDataGridViewTextBoxColumn";
            this.telpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecopacienteDataGridViewTextBoxColumn
            // 
            this.enderecopacienteDataGridViewTextBoxColumn.DataPropertyName = "endereco_paciente";
            this.enderecopacienteDataGridViewTextBoxColumn.HeaderText = "endereco_paciente";
            this.enderecopacienteDataGridViewTextBoxColumn.Name = "enderecopacienteDataGridViewTextBoxColumn";
            this.enderecopacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailpacienteDataGridViewTextBoxColumn
            // 
            this.emailpacienteDataGridViewTextBoxColumn.DataPropertyName = "email_paciente";
            this.emailpacienteDataGridViewTextBoxColumn.HeaderText = "email_paciente";
            this.emailpacienteDataGridViewTextBoxColumn.Name = "emailpacienteDataGridViewTextBoxColumn";
            this.emailpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estcivilpacienteDataGridViewTextBoxColumn
            // 
            this.estcivilpacienteDataGridViewTextBoxColumn.DataPropertyName = "estcivil_paciente";
            this.estcivilpacienteDataGridViewTextBoxColumn.HeaderText = "estcivil_paciente";
            this.estcivilpacienteDataGridViewTextBoxColumn.Name = "estcivilpacienteDataGridViewTextBoxColumn";
            this.estcivilpacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profissaopacienteDataGridViewTextBoxColumn
            // 
            this.profissaopacienteDataGridViewTextBoxColumn.DataPropertyName = "profissao_paciente";
            this.profissaopacienteDataGridViewTextBoxColumn.HeaderText = "profissao_paciente";
            this.profissaopacienteDataGridViewTextBoxColumn.Name = "profissaopacienteDataGridViewTextBoxColumn";
            this.profissaopacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anotacoespacienteDataGridViewTextBoxColumn
            // 
            this.anotacoespacienteDataGridViewTextBoxColumn.DataPropertyName = "anotacoes_paciente";
            this.anotacoespacienteDataGridViewTextBoxColumn.HeaderText = "anotacoes_paciente";
            this.anotacoespacienteDataGridViewTextBoxColumn.Name = "anotacoespacienteDataGridViewTextBoxColumn";
            this.anotacoespacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bunifuCustomDataGrid2);
            this.panel7.Location = new System.Drawing.Point(0, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1091, 527);
            this.panel7.TabIndex = 129;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Limpar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(959, 232);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(110, 41);
            this.bunifuThinButton21.TabIndex = 130;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Tratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adicionartratamento);
            this.Controls.Add(this.alterartratamento);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descricaotratamento);
            this.Controls.Add(this.excluirtratamento);
            this.Controls.Add(this.precotratamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dentesregiao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nometratamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iniciotermino);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.plano);
            this.Controls.Add(this.bunifuThinButton21);
            this.Name = "Tratamento";
            this.Size = new System.Drawing.Size(1091, 572);
            this.Load += new System.EventHandler(this.Tratamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc_consultorioDataSet3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private tcc_consultorioDataSet tcc_consultorioDataSet;
        private tcc_consultorioDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource tratamentoBindingSource;
        private tcc_consultorioDataSet3 tcc_consultorioDataSet3;
        private tcc_consultorioDataSet3TableAdapters.tratamentoTableAdapter tratamentoTableAdapter;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 adicionartratamento;
        private Bunifu.Framework.UI.BunifuThinButton2 alterartratamento;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPacienteTratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox descricaotratamento;
        private Bunifu.Framework.UI.BunifuThinButton2 excluirtratamento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox precotratamento;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dentesregiao;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nometratamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox iniciotermino;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox plano;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecopacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estcivilpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissaopacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anotacoespacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuCustomLabel nomepaciente;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
