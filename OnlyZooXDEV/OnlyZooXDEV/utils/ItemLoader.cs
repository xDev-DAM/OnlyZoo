using OnlyZooXDEV.connection;

namespace OnlyZooXDEV.utils
{
    internal class ItemLoader
    {
        private MainWindow Window;
        public ItemLoader(MainWindow window)
        {
            Window = window;
        }
        public void LoadProducts()
        {
            Window.ItemContainer.Controls.Clear();
            Window.TitleLabel.Text = "PRODUCTOS";
            ProductConnector._instance.LoadListFromDatabase();
            ProductConnector._instance.products.Products.ForEach(prod => {
                CreateItem(prod.Name, prod.Image);
            });
        }

        public void LoadPets() {
            Window.ItemContainer.Controls.Clear();
            Window.TitleLabel.Text = "MASCOTAS";
            PetConnector._instance.LoadListFromDatabase();
            PetConnector._instance.pets.Pets.ForEach(pet => {
                CreateItem(pet.Name, pet.Image);
            });
        }

        public void LoadMerch() {
            Window.ItemContainer.Controls.Clear();
            Window.TitleLabel.Text = "MERCHANDISING";
            MerchConnector._instance.LoadListFromDatabase();
            MerchConnector._instance.merchs.Merchs.ForEach(merch => {
                CreateItem(merch.Name, merch.Image);
            });

        }

        public void LoadFeatured() { }
        public void CreateItem(string name, string image)
        {
            Button b = new Button();
            b.Size = new Size(210, 210);
            b.Margin = new Padding(20, 20, 3, 3);
            b.Cursor = Cursors.Hand;
            b.Text = name;
            b.Font = new FontManager().SmallFont();
            b.FlatStyle = FlatStyle.Popup;
            Image myimage = new Bitmap(image);
            b.BackgroundImage = myimage;
            b.BackgroundImageLayout = ImageLayout.Stretch;
            b.TextAlign = ContentAlignment.BottomCenter;
            b.Click += new System.EventHandler(Window.ItemClicked);
            b.Parent = Window.ItemContainer;
        }
    }
}

