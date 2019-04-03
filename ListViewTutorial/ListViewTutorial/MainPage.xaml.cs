using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewTutorial
{
    public partial class MainPage : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            string[] name, location, img;

            name = new string[] { "Capuchin Monkey", "Blue Monkey", "Squirrel Monkey", "Golden Lion Tamarin", "Baboon" };

            location = new string[] { "Central & South America", "Central and East Africa", "Central & South America", "Brazil", "Africa & Asia"};

            img = new string[] { "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg",
            "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
            "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg",
             "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg",
             "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            };

            Monkeys = new List<Monkey>();

            for (int i = 0; i < name.Length; i++)
            {
                Monkeys.Add(new Monkey
                {
                    Name = name[i],
                    Location = location[i],
                    ImageUrl = img[i]
                });
            }

            BindingContext = this;
        }
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Monkey selectedItem = e.SelectedItem as Monkey;
            Console.WriteLine("Selected: " + selectedItem.Name);
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Monkey tappedItem = e.Item as Monkey;
            Console.WriteLine("Tapped: " + tappedItem.Name);
        }
    }
}
