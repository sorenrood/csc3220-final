using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;

namespace Project4 {
    public partial class mainForm : Form {
        public decimal chocolatePrice = 4.00M;
        public decimal vanillaPrice = 2.00M;
        public decimal strawberryPrice = 3.00M;

        public decimal sprinklesPrice = 0.50M;
        public decimal choppedNutsPrice = 0.75M;
        public decimal cherryPrice = 1.00M;

        
        public mainForm() {
            InitializeComponent();
        }

        private void buttonTotalPrice_Click(object sender, EventArgs e) {
            decimal orderTotal = 0.00M;
            foreach (string money in listBoxOrders.Items) {
                orderTotal += Decimal.Parse(money, NumberStyles.Currency);
            }

            labelTotalPrice.Text = "$" + orderTotal.ToString();
            listBoxAllOrders.Items.Add("$" + orderTotal.ToString());
        }

        private void buttonAddOrder_Click(object sender, EventArgs e) {
            decimal totalPrice = 0;

            if (radioButtonChocolate.Checked) {
                totalPrice += chocolatePrice;
            }
            else if (radioButtonStrawberry.Checked) {
                totalPrice += strawberryPrice;
            }
            else if (radioButtonVanilla.Checked) {
                totalPrice += vanillaPrice;
            }

            if (checkBoxSprinkles.Checked) {
                totalPrice += sprinklesPrice;
            }

            if (checkBoxChoppedNuts.Checked) {
                totalPrice += choppedNutsPrice;
            }

            if (checkBoxCherry.Checked) {
                totalPrice += cherryPrice;
            }

            listBoxOrders.Items.Add("$" + totalPrice.ToString());
        }

        private void buttonClearOrders_Click(object sender, EventArgs e) {
            listBoxOrders.Items.Clear();
        }

        private void buttonTotalUp_Click(object sender, EventArgs e) {
            decimal totalUpAmount = 0.00M;
            foreach (string money in listBoxAllOrders.Items) {
                totalUpAmount += Decimal.Parse(money, NumberStyles.Currency);
            }

            // Create the database entry
            string now = DateTime.Now.ToString();
            string entry = $"{now}: ${totalUpAmount}";
            labelTotalTransactions.Text = ("$" + totalUpAmount.ToString());

            //  Connect to DB and define query string
            string connectionString = "Data Source=(local); integrated security=SSPI; Database=StuffForUs";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = $"Insert Into dbo.Orders (Orders) Values ({now}: {entry})";
            
            // Create and execute sql command
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        private void priceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPriceSheet priceSheet = new formPriceSheet();
            priceSheet.Show();
            priceSheet.mainForm = this;
            priceSheet.showDefaults();
        }

        public void setPrices(string chocPrice, string vanPrice, string strawPrice, string nutPrice, string cherPrice, string sprinkPrice)
        {
            chocolatePrice = Convert.ToDecimal(chocPrice);
            vanillaPrice = Convert.ToDecimal(vanPrice);
            strawberryPrice = Convert.ToDecimal(strawPrice);

            choppedNutsPrice = Convert.ToDecimal(nutPrice);
            cherryPrice = Convert.ToDecimal(cherPrice);
            sprinklesPrice = Convert.ToDecimal(sprinkPrice);
        }
    }
}
