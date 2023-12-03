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
    public partial class ItemDetailForm : Form
    {
        public ItemDetailForm()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public void InitializeEvents()
        {
            this.Load -= new System.EventHandler(ItemWindowLoader);

            this.Load += new System.EventHandler(ItemWindowLoader);
        }

        private void ItemWindowLoader(object? sender, EventArgs e)
        {
            LoadFonts(new FontManager());
            LoadColors();
        }

        private void LoadColors()
        {
            this.TopPanel.BackColor = ColorManager.GetPaletteColor1();
            this.MainPanel.BackColor = ColorManager.GetPaletteColor3();
            this.BotPanel.BackColor = ColorManager.GetPaletteColor1();
            this.BuyButton.BackColor = Color.White;
            this.ReportButton.BackColor = Color.White;
        }

        private void LoadFonts(FontManager f)
        {
            this.TitleLabel.Font = f.TitleFont();
            this.StockLabel.Font = f.MediumFont();
            this.PrizeLabel.Font = f.MediumFont();
            this.DescriptionLabel.Font = f.SmallFont();
        }
    }
}
