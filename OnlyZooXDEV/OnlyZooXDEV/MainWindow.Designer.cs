namespace OnlyZooXDEV
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            TopPanel = new Panel();
            TopTitlePanel = new TableLayoutPanel();
            OnlyZooLabel = new Label();
            TopLeftPanel = new FlowLayoutPanel();
            ProductsButton = new Button();
            PetButton = new Button();
            MerchButton = new Button();
            FeaturedButton = new Button();
            TopRightPanel = new FlowLayoutPanel();
            ProfileButton = new Button();
            BotSeparatorLabel = new Label();
            MainPanel = new Panel();
            SubMainPanel = new Panel();
            ItemContainer = new FlowLayoutPanel();
            MainBotPanel = new FlowLayoutPanel();
            LogoXdev = new PictureBox();
            OnlyZooLogo = new PictureBox();
            CopyRightLabel = new Label();
            MainTopPanel = new Panel();
            TitlePanel = new TableLayoutPanel();
            TitleLabel = new Label();
            SearchPanel = new TableLayoutPanel();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            SearchLabel = new Label();
            FilterPanel = new TableLayoutPanel();
            StockFilter = new Button();
            SpecieFilter = new Button();
            PrizeFilter = new Button();
            FilterLabel = new Label();
            miniToolStrip = new MenuStrip();
            verToolStripMenuItem = new ToolStripMenuItem();
            catálogoDeMascotasToolStripMenuItem = new ToolStripMenuItem();
            catálogoDeProductosToolStripMenuItem = new ToolStripMenuItem();
            catálogoDeMerchandaingToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            bindingSource1 = new BindingSource(components);
            TopPanel.SuspendLayout();
            TopTitlePanel.SuspendLayout();
            TopLeftPanel.SuspendLayout();
            TopRightPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SubMainPanel.SuspendLayout();
            MainBotPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoXdev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OnlyZooLogo).BeginInit();
            MainTopPanel.SuspendLayout();
            TitlePanel.SuspendLayout();
            SearchPanel.SuspendLayout();
            FilterPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(TopTitlePanel);
            TopPanel.Controls.Add(TopLeftPanel);
            TopPanel.Controls.Add(TopRightPanel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1193, 57);
            TopPanel.TabIndex = 0;
            // 
            // TopTitlePanel
            // 
            TopTitlePanel.ColumnCount = 3;
            TopTitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.0445328F));
            TopTitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.9554672F));
            TopTitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 176F));
            TopTitlePanel.Controls.Add(OnlyZooLabel, 1, 0);
            TopTitlePanel.Dock = DockStyle.Fill;
            TopTitlePanel.Location = new Point(334, 0);
            TopTitlePanel.Name = "TopTitlePanel";
            TopTitlePanel.RowCount = 1;
            TopTitlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 47.4576263F));
            TopTitlePanel.Size = new Size(795, 57);
            TopTitlePanel.TabIndex = 2;
            // 
            // OnlyZooLabel
            // 
            OnlyZooLabel.AutoSize = true;
            OnlyZooLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            OnlyZooLabel.Location = new Point(232, 8);
            OnlyZooLabel.Margin = new Padding(3, 8, 3, 0);
            OnlyZooLabel.Name = "OnlyZooLabel";
            OnlyZooLabel.Size = new Size(90, 30);
            OnlyZooLabel.TabIndex = 2;
            OnlyZooLabel.Text = "OnlyZoo";
            // 
            // TopLeftPanel
            // 
            TopLeftPanel.Controls.Add(ProductsButton);
            TopLeftPanel.Controls.Add(PetButton);
            TopLeftPanel.Controls.Add(MerchButton);
            TopLeftPanel.Controls.Add(FeaturedButton);
            TopLeftPanel.Dock = DockStyle.Left;
            TopLeftPanel.Location = new Point(0, 0);
            TopLeftPanel.Name = "TopLeftPanel";
            TopLeftPanel.Size = new Size(334, 57);
            TopLeftPanel.TabIndex = 1;
            // 
            // ProductsButton
            // 
            ProductsButton.Location = new Point(3, 8);
            ProductsButton.Margin = new Padding(3, 8, 3, 3);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(80, 41);
            ProductsButton.TabIndex = 0;
            ProductsButton.Text = "Productos";
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // PetButton
            // 
            PetButton.Location = new Point(89, 8);
            PetButton.Margin = new Padding(3, 8, 3, 3);
            PetButton.Name = "PetButton";
            PetButton.Size = new Size(75, 41);
            PetButton.TabIndex = 1;
            PetButton.Text = "Mascotas";
            PetButton.UseVisualStyleBackColor = true;
            // 
            // MerchButton
            // 
            MerchButton.Location = new Point(170, 8);
            MerchButton.Margin = new Padding(3, 8, 3, 3);
            MerchButton.Name = "MerchButton";
            MerchButton.Size = new Size(75, 41);
            MerchButton.TabIndex = 2;
            MerchButton.Text = "Merch";
            MerchButton.UseVisualStyleBackColor = true;
            // 
            // FeaturedButton
            // 
            FeaturedButton.Location = new Point(251, 8);
            FeaturedButton.Margin = new Padding(3, 8, 3, 3);
            FeaturedButton.Name = "FeaturedButton";
            FeaturedButton.Size = new Size(77, 41);
            FeaturedButton.TabIndex = 3;
            FeaturedButton.Text = "Destacados";
            FeaturedButton.UseVisualStyleBackColor = true;
            // 
            // TopRightPanel
            // 
            TopRightPanel.Controls.Add(ProfileButton);
            TopRightPanel.Dock = DockStyle.Right;
            TopRightPanel.FlowDirection = FlowDirection.RightToLeft;
            TopRightPanel.Location = new Point(1129, 0);
            TopRightPanel.Name = "TopRightPanel";
            TopRightPanel.Size = new Size(64, 57);
            TopRightPanel.TabIndex = 0;
            // 
            // ProfileButton
            // 
            ProfileButton.Image = (Image)resources.GetObject("ProfileButton.Image");
            ProfileButton.Location = new Point(9, 8);
            ProfileButton.Margin = new Padding(3, 8, 10, 3);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(45, 41);
            ProfileButton.TabIndex = 0;
            ProfileButton.UseVisualStyleBackColor = true;
            // 
            // BotSeparatorLabel
            // 
            BotSeparatorLabel.BorderStyle = BorderStyle.Fixed3D;
            BotSeparatorLabel.Location = new Point(-6, 8);
            BotSeparatorLabel.Name = "BotSeparatorLabel";
            BotSeparatorLabel.Size = new Size(886, 3);
            BotSeparatorLabel.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.BorderStyle = BorderStyle.Fixed3D;
            MainPanel.Controls.Add(SubMainPanel);
            MainPanel.Controls.Add(MainTopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 57);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1193, 639);
            MainPanel.TabIndex = 2;
            // 
            // SubMainPanel
            // 
            SubMainPanel.Controls.Add(ItemContainer);
            SubMainPanel.Controls.Add(MainBotPanel);
            SubMainPanel.Dock = DockStyle.Fill;
            SubMainPanel.Location = new Point(0, 61);
            SubMainPanel.Name = "SubMainPanel";
            SubMainPanel.Size = new Size(1189, 574);
            SubMainPanel.TabIndex = 1;
            // 
            // ItemContainer
            // 
            ItemContainer.AutoScroll = true;
            ItemContainer.Dock = DockStyle.Fill;
            ItemContainer.Location = new Point(0, 0);
            ItemContainer.Name = "ItemContainer";
            ItemContainer.Size = new Size(1189, 515);
            ItemContainer.TabIndex = 13;
            // 
            // MainBotPanel
            // 
            MainBotPanel.BorderStyle = BorderStyle.FixedSingle;
            MainBotPanel.Controls.Add(LogoXdev);
            MainBotPanel.Controls.Add(OnlyZooLogo);
            MainBotPanel.Controls.Add(CopyRightLabel);
            MainBotPanel.Dock = DockStyle.Bottom;
            MainBotPanel.FlowDirection = FlowDirection.RightToLeft;
            MainBotPanel.Location = new Point(0, 515);
            MainBotPanel.Name = "MainBotPanel";
            MainBotPanel.Size = new Size(1189, 59);
            MainBotPanel.TabIndex = 12;
            // 
            // LogoXdev
            // 
            LogoXdev.Image = (Image)resources.GetObject("LogoXdev.Image");
            LogoXdev.Location = new Point(1134, 3);
            LogoXdev.Name = "LogoXdev";
            LogoXdev.Size = new Size(50, 51);
            LogoXdev.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoXdev.TabIndex = 6;
            LogoXdev.TabStop = false;
            // 
            // OnlyZooLogo
            // 
            OnlyZooLogo.Image = (Image)resources.GetObject("OnlyZooLogo.Image");
            OnlyZooLogo.Location = new Point(1073, 3);
            OnlyZooLogo.Name = "OnlyZooLogo";
            OnlyZooLogo.Size = new Size(55, 51);
            OnlyZooLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            OnlyZooLogo.TabIndex = 7;
            OnlyZooLogo.TabStop = false;
            // 
            // CopyRightLabel
            // 
            CopyRightLabel.AutoSize = true;
            CopyRightLabel.Location = new Point(471, 20);
            CopyRightLabel.Margin = new Padding(3, 20, 10, 0);
            CopyRightLabel.Name = "CopyRightLabel";
            CopyRightLabel.Size = new Size(589, 15);
            CopyRightLabel.TabIndex = 8;
            CopyRightLabel.Text = "Esta aplicación ha sido desarrollada por el equipo de trabajo XDEV-DAMv2© con fines puramente académicos.";
            // 
            // MainTopPanel
            // 
            MainTopPanel.Controls.Add(TitlePanel);
            MainTopPanel.Controls.Add(SearchPanel);
            MainTopPanel.Controls.Add(FilterPanel);
            MainTopPanel.Dock = DockStyle.Top;
            MainTopPanel.Location = new Point(0, 0);
            MainTopPanel.Name = "MainTopPanel";
            MainTopPanel.Size = new Size(1189, 61);
            MainTopPanel.TabIndex = 0;
            // 
            // TitlePanel
            // 
            TitlePanel.ColumnCount = 3;
            TitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.6735764F));
            TitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.3264236F));
            TitlePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            TitlePanel.Controls.Add(TitleLabel, 1, 0);
            TitlePanel.Dock = DockStyle.Fill;
            TitlePanel.Location = new Point(241, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.RowCount = 2;
            TitlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 86.88525F));
            TitlePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1147537F));
            TitlePanel.Size = new Size(752, 61);
            TitlePanel.TabIndex = 21;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(292, 15);
            TitleLabel.Margin = new Padding(3, 15, 3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(152, 32);
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "TITULO AQUI";
            // 
            // SearchPanel
            // 
            SearchPanel.ColumnCount = 2;
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.17904F));
            SearchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.820961F));
            SearchPanel.Controls.Add(SearchTextBox, 0, 1);
            SearchPanel.Controls.Add(SearchButton, 1, 1);
            SearchPanel.Controls.Add(SearchLabel, 0, 0);
            SearchPanel.Dock = DockStyle.Left;
            SearchPanel.Location = new Point(0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.RowCount = 2;
            SearchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45.901638F));
            SearchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 54.098362F));
            SearchPanel.Size = new Size(241, 61);
            SearchPanel.TabIndex = 20;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(10, 31);
            SearchTextBox.Margin = new Padding(10, 3, 3, 3);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(157, 23);
            SearchTextBox.TabIndex = 18;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(174, 31);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(63, 23);
            SearchButton.TabIndex = 19;
            SearchButton.Text = "search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchLabel.Location = new Point(10, 7);
            SearchLabel.Margin = new Padding(10, 7, 3, 0);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(129, 21);
            SearchLabel.TabIndex = 20;
            SearchLabel.Text = "Búsqueda rápida:";
            // 
            // FilterPanel
            // 
            FilterPanel.ColumnCount = 3;
            FilterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.7131767F));
            FilterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.2868233F));
            FilterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            FilterPanel.Controls.Add(StockFilter, 0, 1);
            FilterPanel.Controls.Add(SpecieFilter, 2, 1);
            FilterPanel.Controls.Add(PrizeFilter, 1, 1);
            FilterPanel.Controls.Add(FilterLabel, 0, 0);
            FilterPanel.Dock = DockStyle.Right;
            FilterPanel.Location = new Point(993, 0);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.RowCount = 2;
            FilterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.18033F));
            FilterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.81967F));
            FilterPanel.Size = new Size(196, 61);
            FilterPanel.TabIndex = 17;
            // 
            // StockFilter
            // 
            StockFilter.Location = new Point(3, 33);
            StockFilter.Name = "StockFilter";
            StockFilter.Size = new Size(62, 23);
            StockFilter.TabIndex = 16;
            StockFilter.Text = "Stock";
            StockFilter.UseVisualStyleBackColor = true;
            // 
            // SpecieFilter
            // 
            SpecieFilter.Location = new Point(132, 33);
            SpecieFilter.Margin = new Padding(3, 3, 10, 3);
            SpecieFilter.Name = "SpecieFilter";
            SpecieFilter.Size = new Size(54, 23);
            SpecieFilter.TabIndex = 14;
            SpecieFilter.Text = "Especie";
            SpecieFilter.UseVisualStyleBackColor = true;
            // 
            // PrizeFilter
            // 
            PrizeFilter.Location = new Point(71, 33);
            PrizeFilter.Name = "PrizeFilter";
            PrizeFilter.Size = new Size(53, 23);
            PrizeFilter.TabIndex = 15;
            PrizeFilter.Text = "Precio";
            PrizeFilter.UseVisualStyleBackColor = true;
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FilterLabel.Location = new Point(3, 7);
            FilterLabel.Margin = new Padding(3, 7, 3, 0);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(56, 21);
            FilterLabel.TabIndex = 17;
            FilterLabel.Text = "Filtros:";
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Location = new Point(41, 2);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(43, 24);
            miniToolStrip.TabIndex = 2;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catálogoDeMascotasToolStripMenuItem, catálogoDeProductosToolStripMenuItem, catálogoDeMerchandaingToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            // 
            // catálogoDeMascotasToolStripMenuItem
            // 
            catálogoDeMascotasToolStripMenuItem.Name = "catálogoDeMascotasToolStripMenuItem";
            catálogoDeMascotasToolStripMenuItem.Size = new Size(218, 22);
            catálogoDeMascotasToolStripMenuItem.Text = "Catálogo de mascotas";
            // 
            // catálogoDeProductosToolStripMenuItem
            // 
            catálogoDeProductosToolStripMenuItem.Name = "catálogoDeProductosToolStripMenuItem";
            catálogoDeProductosToolStripMenuItem.Size = new Size(218, 22);
            catálogoDeProductosToolStripMenuItem.Text = "Catálogo de productos";
            // 
            // catálogoDeMerchandaingToolStripMenuItem
            // 
            catálogoDeMerchandaingToolStripMenuItem.Name = "catálogoDeMerchandaingToolStripMenuItem";
            catálogoDeMerchandaingToolStripMenuItem.Size = new Size(218, 22);
            catálogoDeMerchandaingToolStripMenuItem.Text = "Catálogo de merchandaing";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(43, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 696);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            Name = "MainWindow";
            Text = "MainWindow";
            TopPanel.ResumeLayout(false);
            TopTitlePanel.ResumeLayout(false);
            TopTitlePanel.PerformLayout();
            TopLeftPanel.ResumeLayout(false);
            TopRightPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            SubMainPanel.ResumeLayout(false);
            MainBotPanel.ResumeLayout(false);
            MainBotPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoXdev).EndInit();
            ((System.ComponentModel.ISupportInitialize)OnlyZooLogo).EndInit();
            MainTopPanel.ResumeLayout(false);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            FilterPanel.ResumeLayout(false);
            FilterPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private FlowLayoutPanel TopRightPanel;
        private Button ProfileButton;
        private Panel MainPanel;
        private Panel MainTopPanel;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private TableLayoutPanel FilterPanel;
        private Button StockFilter;
        private Button SpecieFilter;
        private Button PrizeFilter;
        private Label FilterLabel;
        private FlowLayoutPanel TopLeftPanel;
        private TableLayoutPanel SearchPanel;
        private Label SearchLabel;
        private MenuStrip miniToolStrip;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem catálogoDeMascotasToolStripMenuItem;
        private ToolStripMenuItem catálogoDeProductosToolStripMenuItem;
        private ToolStripMenuItem catálogoDeMerchandaingToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button ProductsButton;
        private Button PetButton;
        private Button MerchButton;
        private TableLayoutPanel TitlePanel;
        private Label TitleLabel;
        private TableLayoutPanel TopTitlePanel;
        private Label OnlyZooLabel;
        private Label BotSeparatorLabel;
        private BindingSource bindingSource1;
        private Button FeaturedButton;
        private Panel SubMainPanel;
        private FlowLayoutPanel ItemContainer;
        private FlowLayoutPanel MainBotPanel;
        private PictureBox LogoXdev;
        private PictureBox OnlyZooLogo;
        private Label CopyRightLabel;
    }
}