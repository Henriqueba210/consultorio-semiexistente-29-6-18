namespace WindowsFormsApp2
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.tratamento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CadastrarDentista = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Estoque = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CadastrarPaciente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dentista1 = new WindowsFormsApp2.dentista();
            this.estoque1 = new WindowsFormsApp2.Estoque();
            this.tratamento1 = new WindowsFormsApp2.Tratamento();
            this.cadastrar_paciente1 = new WindowsFormsApp2.cadastrar_paciente();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuColorTransition2 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.bunifuImageButton2);
            this.panelTop.Controls.Add(this.bunifuCustomLabel1);
            this.PanelAnimator.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1147, 25);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.LogoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1115, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(26, 22);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(36, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(39, 17);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Smilit";
            // 
            // sidemenu
            // 
            this.sidemenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sidemenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.sidemenu.Controls.Add(this.tratamento);
            this.sidemenu.Controls.Add(this.Home);
            this.sidemenu.Controls.Add(this.CadastrarDentista);
            this.sidemenu.Controls.Add(this.Estoque);
            this.sidemenu.Controls.Add(this.CadastrarPaciente);
            this.sidemenu.Controls.Add(this.btnMenu);
            this.sidemenu.Controls.Add(this.logo);
            this.PanelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.ForeColor = System.Drawing.SystemColors.Control;
            this.sidemenu.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.sidemenu.Location = new System.Drawing.Point(0, 24);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(56, 576);
            this.sidemenu.TabIndex = 1;
            // 
            // tratamento
            // 
            this.tratamento.Activecolor = System.Drawing.Color.White;
            this.tratamento.BackColor = System.Drawing.Color.RoyalBlue;
            this.tratamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tratamento.BorderRadius = 0;
            this.tratamento.ButtonText = "   Tratamentos";
            this.tratamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.tratamento, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.tratamento, BunifuAnimatorNS.DecorationType.None);
            this.tratamento.DisabledColor = System.Drawing.Color.Gray;
            this.tratamento.Iconcolor = System.Drawing.Color.Transparent;
            this.tratamento.Iconimage = global::WindowsFormsApp2.Properties.Resources.if_Dental___Tooth___Dentist___Dentistry_21_2185082;
            this.tratamento.Iconimage_right = null;
            this.tratamento.Iconimage_right_Selected = null;
            this.tratamento.Iconimage_Selected = null;
            this.tratamento.IconMarginLeft = 0;
            this.tratamento.IconMarginRight = 0;
            this.tratamento.IconRightVisible = true;
            this.tratamento.IconRightZoom = 0D;
            this.tratamento.IconVisible = true;
            this.tratamento.IconZoom = 80D;
            this.tratamento.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.tratamento.IsTab = true;
            this.tratamento.Location = new System.Drawing.Point(0, 410);
            this.tratamento.Name = "tratamento";
            this.tratamento.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.tratamento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(134)))));
            this.tratamento.OnHoverTextColor = System.Drawing.Color.White;
            this.tratamento.selected = false;
            this.tratamento.Size = new System.Drawing.Size(216, 48);
            this.tratamento.TabIndex = 9;
            this.tratamento.Text = "   Tratamentos";
            this.tratamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tratamento.Textcolor = System.Drawing.Color.White;
            this.tratamento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratamento.Click += new System.EventHandler(this.Adicionar_Tratamento_Click);
            // 
            // Home
            // 
            this.Home.Activecolor = System.Drawing.Color.White;
            this.Home.BackColor = System.Drawing.Color.RoyalBlue;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.BorderRadius = 0;
            this.Home.ButtonText = "   Menu";
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.Home, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Home, BunifuAnimatorNS.DecorationType.None);
            this.Home.DisabledColor = System.Drawing.Color.Gray;
            this.Home.Iconcolor = System.Drawing.Color.Transparent;
            this.Home.Iconimage = global::WindowsFormsApp2.Properties.Resources.Home_40px;
            this.Home.Iconimage_right = null;
            this.Home.Iconimage_right_Selected = null;
            this.Home.Iconimage_Selected = null;
            this.Home.IconMarginLeft = 0;
            this.Home.IconMarginRight = 0;
            this.Home.IconRightVisible = true;
            this.Home.IconRightZoom = 0D;
            this.Home.IconVisible = true;
            this.Home.IconZoom = 80D;
            this.Home.IsTab = true;
            this.Home.Location = new System.Drawing.Point(0, 194);
            this.Home.Name = "Home";
            this.Home.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(134)))));
            this.Home.OnHoverTextColor = System.Drawing.Color.White;
            this.Home.selected = false;
            this.Home.Size = new System.Drawing.Size(217, 48);
            this.Home.TabIndex = 8;
            this.Home.Text = "   Menu";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Textcolor = System.Drawing.Color.White;
            this.Home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // CadastrarDentista
            // 
            this.CadastrarDentista.Activecolor = System.Drawing.Color.White;
            this.CadastrarDentista.BackColor = System.Drawing.Color.RoyalBlue;
            this.CadastrarDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CadastrarDentista.BorderRadius = 0;
            this.CadastrarDentista.ButtonText = "   Cadastro Dentista";
            this.CadastrarDentista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.CadastrarDentista, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.CadastrarDentista, BunifuAnimatorNS.DecorationType.None);
            this.CadastrarDentista.DisabledColor = System.Drawing.Color.Gray;
            this.CadastrarDentista.Iconcolor = System.Drawing.Color.Transparent;
            this.CadastrarDentista.Iconimage = ((System.Drawing.Image)(resources.GetObject("CadastrarDentista.Iconimage")));
            this.CadastrarDentista.Iconimage_right = null;
            this.CadastrarDentista.Iconimage_right_Selected = null;
            this.CadastrarDentista.Iconimage_Selected = null;
            this.CadastrarDentista.IconMarginLeft = 0;
            this.CadastrarDentista.IconMarginRight = 0;
            this.CadastrarDentista.IconRightVisible = true;
            this.CadastrarDentista.IconRightZoom = 0D;
            this.CadastrarDentista.IconVisible = true;
            this.CadastrarDentista.IconZoom = 80D;
            this.CadastrarDentista.IsTab = true;
            this.CadastrarDentista.Location = new System.Drawing.Point(0, 302);
            this.CadastrarDentista.Name = "CadastrarDentista";
            this.CadastrarDentista.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.CadastrarDentista.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(134)))));
            this.CadastrarDentista.OnHoverTextColor = System.Drawing.Color.White;
            this.CadastrarDentista.selected = false;
            this.CadastrarDentista.Size = new System.Drawing.Size(217, 48);
            this.CadastrarDentista.TabIndex = 5;
            this.CadastrarDentista.Text = "   Cadastro Dentista";
            this.CadastrarDentista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadastrarDentista.Textcolor = System.Drawing.Color.White;
            this.CadastrarDentista.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarDentista.Click += new System.EventHandler(this.CadastrarDentista_Click);
            // 
            // Estoque
            // 
            this.Estoque.Activecolor = System.Drawing.Color.White;
            this.Estoque.BackColor = System.Drawing.Color.RoyalBlue;
            this.Estoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Estoque.BorderRadius = 0;
            this.Estoque.ButtonText = "   Estoque";
            this.Estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.Estoque, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Estoque, BunifuAnimatorNS.DecorationType.None);
            this.Estoque.DisabledColor = System.Drawing.Color.Gray;
            this.Estoque.Iconcolor = System.Drawing.Color.Transparent;
            this.Estoque.Iconimage = global::WindowsFormsApp2.Properties.Resources.if_Dental___Tooth___Dentist___Dentistry_34_2185052;
            this.Estoque.Iconimage_right = null;
            this.Estoque.Iconimage_right_Selected = null;
            this.Estoque.Iconimage_Selected = null;
            this.Estoque.IconMarginLeft = 0;
            this.Estoque.IconMarginRight = 0;
            this.Estoque.IconRightVisible = true;
            this.Estoque.IconRightZoom = 0D;
            this.Estoque.IconVisible = true;
            this.Estoque.IconZoom = 80D;
            this.Estoque.IsTab = true;
            this.Estoque.Location = new System.Drawing.Point(0, 248);
            this.Estoque.Name = "Estoque";
            this.Estoque.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.Estoque.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(134)))));
            this.Estoque.OnHoverTextColor = System.Drawing.Color.White;
            this.Estoque.selected = false;
            this.Estoque.Size = new System.Drawing.Size(217, 48);
            this.Estoque.TabIndex = 4;
            this.Estoque.Text = "   Estoque";
            this.Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Estoque.Textcolor = System.Drawing.Color.White;
            this.Estoque.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque.Click += new System.EventHandler(this.Estoque_Click);
            // 
            // CadastrarPaciente
            // 
            this.CadastrarPaciente.Activecolor = System.Drawing.Color.White;
            this.CadastrarPaciente.BackColor = System.Drawing.Color.RoyalBlue;
            this.CadastrarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CadastrarPaciente.BorderRadius = 0;
            this.CadastrarPaciente.ButtonText = "   Cadasto Paciente";
            this.CadastrarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.CadastrarPaciente, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.CadastrarPaciente, BunifuAnimatorNS.DecorationType.None);
            this.CadastrarPaciente.DisabledColor = System.Drawing.Color.Gray;
            this.CadastrarPaciente.Iconcolor = System.Drawing.Color.Transparent;
            this.CadastrarPaciente.Iconimage = ((System.Drawing.Image)(resources.GetObject("CadastrarPaciente.Iconimage")));
            this.CadastrarPaciente.Iconimage_right = null;
            this.CadastrarPaciente.Iconimage_right_Selected = null;
            this.CadastrarPaciente.Iconimage_Selected = null;
            this.CadastrarPaciente.IconMarginLeft = 0;
            this.CadastrarPaciente.IconMarginRight = 0;
            this.CadastrarPaciente.IconRightVisible = true;
            this.CadastrarPaciente.IconRightZoom = 0D;
            this.CadastrarPaciente.IconVisible = true;
            this.CadastrarPaciente.IconZoom = 80D;
            this.CadastrarPaciente.IsTab = true;
            this.CadastrarPaciente.Location = new System.Drawing.Point(0, 356);
            this.CadastrarPaciente.Name = "CadastrarPaciente";
            this.CadastrarPaciente.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.CadastrarPaciente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(134)))));
            this.CadastrarPaciente.OnHoverTextColor = System.Drawing.Color.White;
            this.CadastrarPaciente.selected = false;
            this.CadastrarPaciente.Size = new System.Drawing.Size(217, 48);
            this.CadastrarPaciente.TabIndex = 3;
            this.CadastrarPaciente.Text = "   Cadasto Paciente";
            this.CadastrarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadastrarPaciente.Textcolor = System.Drawing.Color.White;
            this.CadastrarPaciente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarPaciente.Click += new System.EventHandler(this.Cadastrar_Paciente_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(12, 10);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 34);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(28, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(121, 107);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            // 
            // monthCalendar1
            // 
            this.LogoAnimator.SetDecoration(this.monthCalendar1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.monthCalendar1, BunifuAnimatorNS.DecorationType.None);
            this.monthCalendar1.Location = new System.Drawing.Point(905, 36);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // dentista1
            // 
            this.dentista1.BackColor = System.Drawing.Color.White;
            this.LogoAnimator.SetDecoration(this.dentista1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.dentista1, BunifuAnimatorNS.DecorationType.None);
            this.dentista1.Location = new System.Drawing.Point(56, 24);
            this.dentista1.Name = "dentista1";
            this.dentista1.Size = new System.Drawing.Size(1085, 577);
            this.dentista1.TabIndex = 7;
            this.dentista1.Visible = false;
            // 
            // estoque1
            // 
            this.estoque1.BackColor = System.Drawing.Color.White;
            this.LogoAnimator.SetDecoration(this.estoque1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.estoque1, BunifuAnimatorNS.DecorationType.None);
            this.estoque1.Location = new System.Drawing.Point(56, 24);
            this.estoque1.Name = "estoque1";
            this.estoque1.Size = new System.Drawing.Size(1085, 573);
            this.estoque1.TabIndex = 6;
            this.estoque1.Visible = false;
            // 
            // tratamento1
            // 
            this.tratamento1.BackColor = System.Drawing.Color.White;
            this.LogoAnimator.SetDecoration(this.tratamento1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.tratamento1, BunifuAnimatorNS.DecorationType.None);
            this.tratamento1.Location = new System.Drawing.Point(56, 24);
            this.tratamento1.Name = "tratamento1";
            this.tratamento1.Size = new System.Drawing.Size(1091, 574);
            this.tratamento1.TabIndex = 5;
            this.tratamento1.Visible = false;
            // 
            // cadastrar_paciente1
            // 
            this.cadastrar_paciente1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cadastrar_paciente1.BackColor = System.Drawing.Color.White;
            this.LogoAnimator.SetDecoration(this.cadastrar_paciente1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.cadastrar_paciente1, BunifuAnimatorNS.DecorationType.None);
            this.cadastrar_paciente1.Location = new System.Drawing.Point(56, 24);
            this.cadastrar_paciente1.Name = "cadastrar_paciente1";
            this.cadastrar_paciente1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cadastrar_paciente1.Size = new System.Drawing.Size(1091, 577);
            this.cadastrar_paciente1.TabIndex = 3;
            this.cadastrar_paciente1.Visible = false;
            this.cadastrar_paciente1.Load += new System.EventHandler(this.cadastrar_paciente1_Load);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.RoyalBlue;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuColorTransition2
            // 
            this.bunifuColorTransition2.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition2.Color2 = System.Drawing.Color.Black;
            this.bunifuColorTransition2.ProgessValue = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 599);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dentista1);
            this.Controls.Add(this.estoque1);
            this.Controls.Add(this.tratamento1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.cadastrar_paciente1);
            this.Controls.Add(this.monthCalendar1);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RG";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuFlatButton CadastrarPaciente;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton CadastrarDentista;
        private Bunifu.Framework.UI.BunifuFlatButton Estoque;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Bunifu.Framework.UI.BunifuFlatButton Home;
        private cadastrar_paciente cadastrar_paciente1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton tratamento;
        private Tratamento tratamento1;
        private Estoque estoque1;
        private dentista dentista1;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

