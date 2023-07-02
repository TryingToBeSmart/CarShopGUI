using System;
using System.Windows.Forms;
using CarClassLibrary1;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        BindingSource carListBinding = new BindingSource();
        BindingSource ShoppingListBinding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }

        private void SetBindings()
        {
            carListBinding.DataSource = store.CarList;

            //tell the form control where to get its data.
            inventoryListBox.DataSource = carListBinding;
            //tells the control what property of the Car class to print on each line.
            ///Recall that the Display property is a combination of all three properties of the Car.
            inventoryListBox.DisplayMember = "Display";
            inventoryListBox.ValueMember = "Display";

            ShoppingListBinding.DataSource = store.ShoppingList;
            cartListBox.DataSource = ShoppingListBinding;
            cartListBox.DisplayMember = "Display";
            cartListBox.ValueMember = "Display";
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                //add selected car to shopping list cart
                store.ShoppingList.Add((Car)inventoryListBox.SelectedItem);
                ShoppingListBinding.ResetBindings(false);
            }
            catch
            {
                MessageBox.Show("select car");
            }

        }

        private void createCarButton_Click(object sender, EventArgs e)
        {
            bool continueCreate = false;//used to check all text is entered correctly
            Car newCar = new Car();

            if (makeTextBox.Text.Length > 0)//not blank
            {
                newCar.Make = makeTextBox.Text;
                continueCreate = true;
            }
            else
            {
                makeTextBox.Text = "Enter Make";
                continueCreate = false;
            }

            if (modelTextBox.Text.Length > 0)//not blank
            {
                newCar.Model = modelTextBox.Text;
                continueCreate = true;
            }
            else modelTextBox.Text = "Enter Model";

            try
            {
                newCar.Price = Decimal.Parse(priceTextBox.Text);
                continueCreate = true;
            }
            catch (Exception)
            {
                priceTextBox.Text = "Enter Price (numbers)";
                continueCreate = false;
            }

            try
            {
                newCar.EngineSize = int.Parse(engineSizeTextBox.Text);

                //ensure correct input
                if (newCar.EngineSize != 4 || newCar.EngineSize != 6 || newCar.EngineSize != 8 ||
                    newCar.EngineSize != 10) throw new Exception();

                else continueCreate = true;
            }
            catch (Exception)
            {
                engineSizeTextBox.Text = "Enter 4, 6, 8, or 10";
                continueCreate = false;
            }

            try
            {
                newCar.Mileage = int.Parse(mileageTextBox.Text);
                continueCreate = true;
            }
            catch (Exception)
            {
                mileageTextBox.Text = "Enter Mileage (numbers only)";
                continueCreate = false;
            }

            //if correct input in every text box, then add newCar to the inventory
            if (continueCreate)
            {
                store.CarList.Add(newCar);
                clearCreateCar();
                carListBinding.ResetBindings(false);
            }
            else MessageBox.Show("Fix Errors");
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = store.checkout();
                totalCostLabel.Text = "$" + total.ToString();
            }
            catch
            {
                MessageBox.Show("Cart Empty");
            }
        }

        private void clearCreateCarButton_Click(object sender, EventArgs e)
        {
            clearCreateCar();
        }

        private void clearCreateCar()
        {
            makeTextBox.Text = string.Empty;
            modelTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            engineSizeTextBox.Text = string.Empty;
            mileageTextBox.Text = string.Empty;
        }
    }
}
