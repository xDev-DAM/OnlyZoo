using OnlyZooXDEV.utils;
using Shipwreck.connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyZooXDEV
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeEvents();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(LoadForm);
            this.IniciarSesionButton.Click -= new System.EventHandler(IniciarSesionButton_Click);

            this.Load += new System.EventHandler(LoadForm);
            this.IniciarSesionButton.Click += new System.EventHandler(IniciarSesionButton_Click);
        }

        private void LoadForm(object? sender, EventArgs e)
        {
            LoadFonts(new FontManager());
            LoadColors();
            LoadItems();
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
        // una prueba para medidas!
        private void LoadItems()
        {
            for (int i = 0; i < 50; i++)
            {
                CreateItem();
            }
        }

        private void CreateItem()
        {
            Button b = new Button();
            b.Size = new Size(210, 210);
            b.Margin = new Padding(20, 20, 3, 3);
            b.Cursor = Cursors.Hand;
            b.Text = "Ejemplo";
            b.FlatStyle = FlatStyle.Popup;
            Image myimage = new Bitmap("image/ejemplo.jpg");
            b.BackgroundImage = myimage;
            b.BackgroundImageLayout = ImageLayout.Stretch;
            b.TextAlign = ContentAlignment.BottomCenter;
            b.Parent = this.ItemContainer;
        }

        private void IniciarSesionButton_Click(object? sender, EventArgs e)
        {
            IniciarSesionForm iniciarSesionForm = new IniciarSesionForm();
            iniciarSesionForm.ShowDialog();
        }
    }
}
