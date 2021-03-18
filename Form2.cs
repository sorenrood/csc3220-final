using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class formPriceSheet : Form
    {
        public mainForm mainForm = null;
        public formPriceSheet()
        {
            InitializeComponent();
        }

        private void buttonSetPrices_Click(object sender, EventArgs e)
        {
            mainForm.setPrices(
                formBoxChocolate.Text,
                formBoxVanilla.Text,
                formBoxStrawberry.Text,
                formBoxChoppedNuts.Text,
                formBoxCherry.Text,
                formBoxSprinkles.Text
                );
            this.Close();
        }

        public void showDefaults()
        {
            // Ice cream flavors.
            formBoxChocolate.Text = mainForm.chocolatePrice.ToString();
            formBoxVanilla.Text = mainForm.vanillaPrice.ToString();
            formBoxStrawberry.Text = mainForm.strawberryPrice.ToString();

            // Toppings.
            formBoxCherry.Text = mainForm.cherryPrice.ToString();
            formBoxSprinkles.Text = mainForm.sprinklesPrice.ToString();
            formBoxChoppedNuts.Text = mainForm.choppedNutsPrice.ToString();
            
        }
    }
}
