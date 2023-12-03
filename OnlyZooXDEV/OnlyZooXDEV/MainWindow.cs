using OnlyZooXDEV.utils;
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
        }

        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(LoadForm);

            this.Load += new System.EventHandler(LoadForm);
        }

        private void LoadForm(object? sender, EventArgs e)
        {
            LoadFonts(new FontManager());
            LoadColors();
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
    }
}
