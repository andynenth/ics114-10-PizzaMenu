using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaMenu
{
    public partial class Form1 : Form
    {
        private float totalPrice;
        private string selectedPizza;
        private string size;
        private string toppings;
        private string diet;
        private string selectedBeverage;
        private string selectedDessert;

        public Form1()
        {
            InitializeComponent();
            totalPrice = 0f;
            
        }

        public bool IsPizzaChecked()
        {
            return listBox1.SelectedIndex != -1;
        }

        private void PizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPizzaChecked())CalulatePizzaPrice();
        }

        private void Toppings_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPizzaChecked()) CalulatePizzaPrice();
        }

        private void Beverage_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPizzaChecked()) CalulatePizzaPrice();
        }

        private void Dessert_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPizzaChecked()) CalulatePizzaPrice();
        }

        private void CalulatePizzaPrice()
        {
            totalPrice = GetPizza();
            totalPrice += AddToppings();
            ChooseSize();
            totalPrice += AddBeverage();
            totalPrice += AddDessert();

            txtTotal.Text = String.Format("{0:C}", totalPrice);

            txtOrder.Text = selectedPizza + Environment.NewLine
                + "Size: " + size + Environment.NewLine
                + "Toppings: " + toppings
                + "Drinks: " + selectedBeverage
                + "Dessert: " + selectedDessert;
        }

        public float AddBeverage()
        {
            selectedBeverage = "";
            float price = 0;
            if (chkCola.Checked)
            {
                price += 2.5f;
                selectedBeverage += "+ " + chkCola.Text + Environment.NewLine;
            }
            if (chkJuice.Checked)
            {
                price += 3f;
                selectedBeverage += "+ " + chkJuice.Text + Environment.NewLine;
            }


            if (price == 0)
            {
                selectedBeverage = "none" + Environment.NewLine;
            }
            return price;
        }

        public float AddDessert()
        {
            selectedDessert = "";
            float price = 0;
            if (chkApplePie.Checked)
            {
                price += 3f;
                selectedDessert += chkApplePie.Text + Environment.NewLine;
            }
            if (chkChocCake.Checked)
            {
                price += 4f;
                selectedDessert += chkChocCake.Text + Environment.NewLine;
            }


            if (price == 0)
            {
                selectedDessert = "none" + Environment.NewLine;
            }
            return price;
        }

        public void ChooseSize()
        {
            if (rdoSmallSize.Checked)
            {
                totalPrice -= 2;
                size = rdoSmallSize.Text;
            }
            else if (rdoLargeSize.Checked)
            {
                totalPrice += 5;
                size = rdoMediumSize.Text;
            }
            else
            {
                size = rdoLargeSize.Text;
            }
        }

        public float GetPizza()
        {
            switch (selectedPizza)
            {
                case "Cheese":
                    return 10f;
                case "Neapolitan":
                    return 10f;
                case "Margherita":
                    return 10f;
                case "Calzone":
                    return 12.5f;
                case "Stromboli":
                    return 12.5f;
                case "Deep dish":
                    return 12.5f;
                case "Marinara":
                    return 12.5f;
                case "Hawaiian":
                    return 12.5f;
                case "Lahma Bi Afeen":
                    return 13f;
                case "M&L Special":
                    return 14f;
                default:
                    return 0;
            }
        }

        public float AddToppings()
        {
            toppings = "";
            float toppingPrice = 0;
            if (cbMushroom.Checked)
            {
                toppingPrice += 2;
                toppings += "+ " + cbMushroom.Text.Remove(cbMushroom.Text.IndexOf("(")-1) + Environment.NewLine;
            }
            if (cbBlackOlive.Checked)
            {
                toppingPrice += 3;
                toppings += "+ " + cbBlackOlive.Text.Remove(cbBlackOlive.Text.IndexOf("(") - 1) + Environment.NewLine;
            }
            if (cbPepperoni.Checked)
            {
                toppingPrice += 5;
                toppings += "+ " + cbPepperoni.Text.Remove(cbPepperoni.Text.IndexOf("(") - 1) + Environment.NewLine;
            }

            if (toppingPrice == 0)
            {
                toppings += "none" + Environment.NewLine;
            }
            return toppingPrice;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPizza = listBox1.SelectedItem.ToString();
            CalulatePizzaPrice();
        }

        private void cboDietary_SelectedIndexChanged(object sender, EventArgs e)
        {
            diet = cboDietary.SelectedItem.ToString();
            ArrayList pizzaType = new ArrayList { "Cheese", "Neapolitan", "Margherita", "Calzone", "Stromboli", "Deep dish", "Marinara", "Hawaiian", "Lahma Bi Afeen", "M&L Special" };
            switch (diet)
            {
                case "Vegan":
                case "Vegetarian":
                    pizzaType.Remove("Hawaiian");
                    pizzaType.Remove("Calzone");
                    pizzaType.Remove("Stromboli");
                    pizzaType.Remove("Lahma Bi Afeen");
                    pizzaType.Remove("M&L Special");
                    break;
                case "Non-GMO":
                    pizzaType.Remove("Stromboli");
                    break;
                case "Gluten free":
                case "Lactose":
                case "Paleo":
                    pizzaType.Remove("Neapolitan");
                    pizzaType.Remove("Margherita");
                    pizzaType.Remove("Deep dish");
                    pizzaType.Remove("Cheese");
                    break;
                case "100 mile":
                case "Kosher":
                    pizzaType.Remove("Hawaiian");
                    pizzaType.Remove("Stromboli");
                    break;                    
            }
            pizzaType.Sort();
            listBox1.Items.Clear();   // Delete all the items already in the ListBox.
            listBox1.Items.AddRange((object[])pizzaType.ToArray()); // Convert the ArrayList to an array.
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdoSmallSize.Checked = false;
            rdoMediumSize.Checked = false;
            rdoLargeSize.Checked = false;
            cbMushroom.Checked = false;
            cbBlackOlive.Checked = false;
            cbPepperoni.Checked = false;
            listBox1.SelectedIndex = 0;
            cboDietary.SelectedIndex = 0;
            chkCola.Checked = false;
            chkJuice.Checked = false;
            chkApplePie.Checked = false;
            chkChocCake.Checked = false;
            txtTotal.Text = "";
            txtOrder.Text = "";
            tabControl1.SelectedIndex = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brought to you by the brothers Mario and Luigi!");
        }
    }
}