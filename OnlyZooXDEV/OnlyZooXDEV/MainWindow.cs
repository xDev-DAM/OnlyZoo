using OnlyZooXDEV.utils;


namespace OnlyZooXDEV
{
    public partial class MainWindow : Form
    {
        ItemLoader loader;
        public MainWindow()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            InitializeEvents();
            loader = new ItemLoader(this);
        }

        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(LoadForm);
            this.IniciarSesionButton.Click -= new System.EventHandler(IniciarSesionButton_Click);
            this.ProductsButton.Click -= new System.EventHandler(LoaderButton_Click);
            this.MerchButton.Click -= new System.EventHandler(LoaderButton_Click);
            this.PetButton.Click -= new System.EventHandler(LoaderButton_Click);

            this.Load += new System.EventHandler(LoadForm);
            this.IniciarSesionButton.Click += new System.EventHandler(IniciarSesionButton_Click);
            this.ProductsButton.Click += new System.EventHandler(LoaderButton_Click);
            this.MerchButton.Click += new System.EventHandler(LoaderButton_Click);
            this.PetButton.Click += new System.EventHandler(LoaderButton_Click);
        }

        private void LoadForm(object? sender, EventArgs e)
        {
            LoadFonts(new FontManager());
            LoadColors();
            loader.LoadProducts();
        }

        private void LoadFonts(FontManager f)
        {
            this.OnlyZooLabel.Font = f.OnlyZooFont();
            this.TitleLabel.Font = f.TitleFont();
            this.SearchLabel.Font = f.SmallFont();
            this.FilterLabel.Font = f.SmallFont();
            this.CopyRightLabel.Font = f.SmallFont();
        }

        private void LoadColors()
        {
            this.TopPanel.BackColor = ColorManager.GetPaletteColor1();
            this.ProductsButton.BackColor = Color.White;
            this.PetButton.BackColor = Color.White;
            this.MerchButton.BackColor = Color.White;
            this.FeaturedButton.BackColor = Color.White;
            this.SearchButton.BackColor = Color.White;
            this.ProfileButton.BackColor = Color.White;
            this.PrizeFilter.BackColor = Color.White;
            this.StockFilter.BackColor = Color.White;
            this.SpecieFilter.BackColor = Color.White;
            this.MainPanel.BackColor = ColorManager.GetPaletteColor3();
            this.MainBotPanel.BackColor = ColorManager.GetPaletteColor1();
        }

        public void ItemClicked(object? sender, EventArgs e)
        {
            new ItemDetailForm().ShowDialog(this);
        }

        private void IniciarSesionButton_Click(object? sender, EventArgs e)
        {
            IniciarSesionForm iniciarSesionForm = new IniciarSesionForm();
            iniciarSesionForm.ShowDialog();
        }

        private void LoaderButton_Click(object? sender, EventArgs e)
        {
            Button b = sender as Button?? new();
            if (b.Text.Equals("Productos")) loader.LoadProducts();
            if (b.Text.Equals("Mascotas")) loader.LoadPets();
            if (b.Text.Equals("Merch")) loader.LoadMerch();
        }
    }
}
