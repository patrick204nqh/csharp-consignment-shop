using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShop
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor
            {
                FirstName = "Bill",
                LastName = "Smith",
            });
            store.Vendors.Add(new Vendor
            {
                FirstName = "Kevin",
                LastName = "Smith",
            });
            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "A tale of two cities",
                Description = "A book about a revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 5.20M,
                Owner = store.Vendors[2]
            });
            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 1.50M,
                Owner = store.Vendors[3]
            });
            store.Name = "Seconds are Better";
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ItemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void headerText_Click(object sender, EventArgs e)
        {

        }
    }
}
