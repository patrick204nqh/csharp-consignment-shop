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
            /*Vendor demoVendor = new Vendor();

            demoVendor.FirstName = "Karl";
            demoVendor.LastName = "Patrick";
            demoVendor.Commission = .5;

            store.Vendors.Add(demoVendor);

            demoVendor = new Vendor();

            demoVendor.FirstName = "Kevin";
            demoVendor.LastName = "Smith";
            demoVendor.Commission = .5;

            store.Vendors.Add(demoVendor);*/

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
