namespace OnlyZooXDEV
{
    partial class ItemDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetailForm));
            MainPanel = new Panel();
            MainRightPanel = new FlowLayoutPanel();
            DescriptionPanel = new FlowLayoutPanel();
            DescriptionLabel = new Label();
            ButtonPanel = new FlowLayoutPanel();
            BuyButton = new Button();
            ReportButton = new Button();
            MainLeftPanel = new FlowLayoutPanel();
            ItemPicture = new PictureBox();
            PrizeLabel = new Label();
            StockLabel = new Label();
            BotPanel = new FlowLayoutPanel();
            TopPanel = new TableLayoutPanel();
            TitleLabel = new Label();
            MainPanel.SuspendLayout();
            MainRightPanel.SuspendLayout();
            DescriptionPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            MainLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPicture).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BorderStyle = BorderStyle.Fixed3D;
            MainPanel.Controls.Add(MainRightPanel);
            MainPanel.Controls.Add(MainLeftPanel);
            MainPanel.Location = new Point(0, 70);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(539, 455);
            MainPanel.TabIndex = 1;
            // 
            // MainRightPanel
            // 
            MainRightPanel.Controls.Add(DescriptionPanel);
            MainRightPanel.Controls.Add(ButtonPanel);
            MainRightPanel.Dock = DockStyle.Right;
            MainRightPanel.FlowDirection = FlowDirection.TopDown;
            MainRightPanel.Location = new Point(248, 0);
            MainRightPanel.Name = "MainRightPanel";
            MainRightPanel.Size = new Size(287, 451);
            MainRightPanel.TabIndex = 1;
            // 
            // DescriptionPanel
            // 
            DescriptionPanel.Controls.Add(DescriptionLabel);
            DescriptionPanel.Location = new Point(3, 3);
            DescriptionPanel.Name = "DescriptionPanel";
            DescriptionPanel.Size = new Size(281, 255);
            DescriptionPanel.TabIndex = 2;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(20, 20);
            DescriptionLabel.Margin = new Padding(20, 20, 10, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(251, 180);
            DescriptionLabel.TabIndex = 1;
            DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(BuyButton);
            ButtonPanel.Controls.Add(ReportButton);
            ButtonPanel.Location = new Point(20, 264);
            ButtonPanel.Margin = new Padding(20, 3, 3, 3);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(244, 87);
            ButtonPanel.TabIndex = 1;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(30, 20);
            BuyButton.Margin = new Padding(30, 20, 3, 3);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(88, 49);
            BuyButton.TabIndex = 0;
            BuyButton.Text = "Comprar";
            BuyButton.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            ReportButton.Location = new Point(131, 20);
            ReportButton.Margin = new Padding(10, 20, 3, 3);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(88, 49);
            ReportButton.TabIndex = 1;
            ReportButton.Text = "Denunciar";
            ReportButton.UseVisualStyleBackColor = true;
            // 
            // MainLeftPanel
            // 
            MainLeftPanel.Controls.Add(ItemPicture);
            MainLeftPanel.Controls.Add(PrizeLabel);
            MainLeftPanel.Controls.Add(StockLabel);
            MainLeftPanel.Dock = DockStyle.Left;
            MainLeftPanel.FlowDirection = FlowDirection.TopDown;
            MainLeftPanel.Location = new Point(0, 0);
            MainLeftPanel.Name = "MainLeftPanel";
            MainLeftPanel.Size = new Size(242, 451);
            MainLeftPanel.TabIndex = 0;
            // 
            // ItemPicture
            // 
            ItemPicture.Image = (Image)resources.GetObject("ItemPicture.Image");
            ItemPicture.Location = new Point(20, 20);
            ItemPicture.Margin = new Padding(20, 20, 3, 3);
            ItemPicture.Name = "ItemPicture";
            ItemPicture.Size = new Size(200, 200);
            ItemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemPicture.TabIndex = 0;
            ItemPicture.TabStop = false;
            // 
            // PrizeLabel
            // 
            PrizeLabel.AutoSize = true;
            PrizeLabel.Location = new Point(20, 243);
            PrizeLabel.Margin = new Padding(20, 20, 3, 0);
            PrizeLabel.Name = "PrizeLabel";
            PrizeLabel.Size = new Size(66, 15);
            PrizeLabel.TabIndex = 1;
            PrizeLabel.Text = "Precio aquí";
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Location = new Point(20, 278);
            StockLabel.Margin = new Padding(20, 20, 3, 0);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(62, 15);
            StockLabel.TabIndex = 2;
            StockLabel.Text = "Stock aquí";
            // 
            // BotPanel
            // 
            BotPanel.Dock = DockStyle.Bottom;
            BotPanel.FlowDirection = FlowDirection.RightToLeft;
            BotPanel.Location = new Point(0, 474);
            BotPanel.Name = "BotPanel";
            BotPanel.Size = new Size(539, 51);
            BotPanel.TabIndex = 2;
            // 
            // TopPanel
            // 
            TopPanel.ColumnCount = 3;
            TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.24933F));
            TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.75067F));
            TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 165F));
            TopPanel.Controls.Add(TitleLabel, 1, 0);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.RowCount = 1;
            TopPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TopPanel.Size = new Size(539, 70);
            TopPanel.TabIndex = 3;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(224, 10);
            TitleLabel.Margin = new Padding(3, 10, 3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(37, 15);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Titulo";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ItemDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 525);
            Controls.Add(TopPanel);
            Controls.Add(BotPanel);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ItemDetailForm";
            Text = "ItemDetailForm";
            MainPanel.ResumeLayout(false);
            MainRightPanel.ResumeLayout(false);
            DescriptionPanel.ResumeLayout(false);
            DescriptionPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            MainLeftPanel.ResumeLayout(false);
            MainLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemPicture).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel MainPanel;
        private FlowLayoutPanel MainLeftPanel;
        private PictureBox ItemPicture;
        private FlowLayoutPanel BotPanel;
        private Label PrizeLabel;
        private FlowLayoutPanel MainRightPanel;
        private Label StockLabel;
        private FlowLayoutPanel ButtonPanel;
        private Button BuyButton;
        private Button ReportButton;
        private FlowLayoutPanel DescriptionPanel;
        private Label DescriptionLabel;
        private TableLayoutPanel TopPanel;
        private Label TitleLabel;
    }
}