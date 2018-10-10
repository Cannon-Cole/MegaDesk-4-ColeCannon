using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_ColeCannon
{
    public partial class AddQuote : Form
    {
        public List<string> materialList = new List<string>();

        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            materialList.Add("Select");

            foreach (var name in Enum.GetNames(typeof(Desk.Materials)))
            {
                materialList.Add(name);
            }

            MaterialCombo.DataSource = materialList;
        }

        private void AddNewQuoteAccept_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(@"C: \Users\Cliff\source\repos\MegaDesk-4-ColeCannon\quotes.txt", append: true);
            try
            {
                wr.WriteLine(HeightInput.Text + "," + WidthInput.Text + "," + MaterialCombo.Text + "," + RushCombo.Text + "," + DrawerUpDown.Value + "," + getPrice());

                QuoteAdded.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("File write issue: " + ex.Message);
            }
            finally
            {
                wr.Close();
            }
        }

        public int getPrice()
        {
            int price = 200;
            price += surfaceAreaPrice(HeightInput.Text, HeightInput.Text);
            price += getMaterialPrice(MaterialCombo.Text);
            price += getRushPrice(RushCombo.Text);
            price += getDrawerPrice((int)DrawerUpDown.Value);

            return price;
        }

        public int calculateSurfaceArea(string height, string width)
        {
            return Int32.Parse(height) * Int32.Parse(width);
        }

        public int surfaceAreaPrice(string height, string width)
        {
            int surfaceArea = calculateSurfaceArea(height, width);

            if (surfaceArea - 1000 > 0)
                return surfaceArea - 1000;
            else
                return 0;
        }

        public int getMaterialPrice(string material)
        {
            switch (material)
            {
                case "Oak":
                    return 200;
                case "Laminate":
                    return 100;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                case "Veneer":
                    return 125;
                default:
                    return 0;
            }
        }

        public int getRushPrice(string rush)
        {

            int days = Int32.Parse(rush.Split(null)[0]);

            int[,] rushCost = {
                { 60, 70, 80 },
                { 40, 50, 60 },
                { 30, 35, 40 }
            };

            int index;
            int area = calculateSurfaceArea(HeightInput.Text, HeightInput.Text);

            if (area > 2000)
            {
                index = 2;
            }
            else if (area > 1000)
            {
                index = 1;
            }
            else
            {
                index = 0;
            }

            switch (days)
            {
                case 3:
                    return rushCost[0, index];
                case 5:
                    return rushCost[1, index]; ;
                case 7:
                    return rushCost[2, index]; ;
                default:
                    return 0;
            }

        }

        public int getDrawerPrice(int numOfDrawers)
        {
            return numOfDrawers * 50;
        }

        private void CancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HeightInputValidation(object sender, CancelEventArgs e)
        {
            string errorMessage;
            int height;

            try
            {
                height = System.Convert.ToInt32(HeightInput.Text);
            }
            catch (FormatException)
            {
                HeightInputErrorLabel.Text = "Not integer";
                height = 0;
            }
            catch (OverflowException)
            {
                HeightInputErrorLabel.Text = "Too big";
                height = 0;
            }

            if (height > Desk.MAX_HEIGHT)
            {
                errorMessage = "Height must be less than or equal to " + Desk.MAX_HEIGHT;
                HeightInputErrorLabel.Text = errorMessage;
                e.Cancel = true;
            }
            else if (height < Desk.MIN_HEIGHT)
            {
                errorMessage = "Height must be greater than or equal to " + Desk.MIN_HEIGHT;
                HeightInputErrorLabel.Text = errorMessage;
                e.Cancel = true;
            }
            else
            {
                HeightInputErrorLabel.Text = "";
            }
        }

        private void WidthValidation(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                WidthCheck(e.KeyChar);
            }
            else
            {
                WidthCheck(e.KeyChar);
                e.Handled = true;
            }

        }

        private void WidthCheck(char key)
        {
            string errorMessage;
            string convert = WidthInput.Text;
            int width;

            if (char.IsControl(key))
            {
                WidthInput.SelectionStart = WidthInput.Text.Length;
            }
            else if (char.IsDigit(key))
            {
                convert += key;
                WidthInput.Text = convert;
                WidthInput.SelectionStart = WidthInput.Text.Length;
            }

            try
            {
                width = System.Convert.ToInt32(WidthInput.Text);
            }
            catch (FormatException)
            {
                WidthInputErrorLabel.Text = "Not integer";
                width = 0;
            }
            catch (OverflowException)
            {
                WidthInputErrorLabel.Text = "Too big";
                width = 0;
            }

            if (width > Desk.MAX_WIDTH)
            {
                errorMessage = "Width must be less than or equal to " + Desk.MAX_WIDTH;
                WidthInputErrorLabel.Text = errorMessage;

            }
            else if (width < Desk.MIN_WIDTH)
            {
                errorMessage = "Width must be greater than or equal to " + Desk.MIN_WIDTH;
                WidthInputErrorLabel.Text = errorMessage;

            }
            else
            {
                WidthInputErrorLabel.Text = "";
            }
        }

        private void HeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightTitle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}