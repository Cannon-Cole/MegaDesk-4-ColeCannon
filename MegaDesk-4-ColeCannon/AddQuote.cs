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

            materialList.Insert(0, "Select");
          
            foreach (var name in Enum.GetNames(typeof(Materials)))
            {
                materialList.Add(name);
                MaterialCombo.Items.Add(name);
            }

            //MaterialCombo.DataSource = materialList;
        }

        private void AddNewQuoteAccept_Click(object sender, EventArgs e)
        {
            bool validated = validateFields();

            if(validated)
            {
            StreamWriter wr = new StreamWriter(@"quotes.txt", append: true);
            try
            {
                string rushtime = "None";

                if (RushCombo.Text != "None")
                { 
                    rushtime = RushCombo.Text.Split(null)[0];
                }

                wr.WriteLine(CustomerNameBox.Text + "," + DateTime.Now.ToString("dd/MM/yyyy") + "," + HeightInput.Text + "," + WidthInput.Text + "," + MaterialCombo.Text + "," + rushtime + "," + DrawerCombo.Text + "," + getPrice());

                QuoteAdded.Visible = true;
              
                NotificationTimer.Enabled = true;
                NotificationTimer.Tick += NotificationTimer_Tick;

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
        }

        private bool validateFields()
        {
            bool name = checkName();
            bool drawers = checkDrawers();
            bool height = checkHeight();
            bool width = checkWidth();
            bool material = checkMaterial();
            bool rush = checkRush();

            if (name && drawers && height && width && material && rush)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            QuoteAdded.Visible = false;
        }

        public int getPrice()
        {
            int price = 200;
            price += surfaceAreaPrice(HeightInput.Text, HeightInput.Text);
            price += getMaterialPrice(MaterialCombo.Text);
            price += getRushPrice(RushCombo.Text);
            price += getDrawerPrice((int.Parse(DrawerCombo.Text)));

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
            //returns price of material selected
            string[] names = Enum.GetNames(typeof(Materials));
            for (int i = 0; i < names.Length; i++)
            {
                if(material == names[i])
                {
                    int[] value = (int[])Enum.GetValues(typeof(Materials));
                    return value[i];
                }
            }

            //should never run
            return 0;

           /* Enum.GetNames(material);

            switch (material)
            {
                case "Oak":
                    return (int)Materials.Oak;
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
            }*/
        }

        public int getRushPrice(string rush)
        {
            int days;

            if (rush != "None")
            {
                days = Int32.Parse(rush.Split(null)[0]);
            }
            else
            {
                days = 0;
            }

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

        private bool checkName()
        {
            if (CustomerNameBox.Text.Length  < 1)
            {
                CustomerNameErrorLabel.Text = "Must enter a name";
                return false;
            }
            else
            {
                CustomerNameErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkHeight()
        {
            string errorMessage = "Must be between " + Desk.MIN_HEIGHT + " and " + Desk.MAX_HEIGHT;
            int heightConvert;
            int height = 0;

            try
            {
                heightConvert = System.Convert.ToInt32(HeightInput.Text);
                height = heightConvert;              
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                HeightInputErrorLabel.Text = "Enter an integer";
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                HeightInputErrorLabel.Text = errorMessage;
            }
            finally
            {
                HeightInputErrorLabel.Text = errorMessage;
                
            }

            if (height > Desk.MAX_HEIGHT)
            {
                HeightInputErrorLabel.Text = errorMessage;
                return false;
            }
            else if (height < Desk.MIN_HEIGHT)
            {
                HeightInputErrorLabel.Text = errorMessage;
                return false;
            }
            else
            {
                HeightInputErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkWidth()
        {
            string errorMessage = "Must be between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH;
            int widthConvert;
            int width = 0;

            try
            {
                widthConvert = System.Convert.ToInt32(WidthInput.Text);
                width = widthConvert;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                WidthInputErrorLabel.Text = errorMessage;
            }

            if (width > Desk.MAX_WIDTH)
            {
                WidthInputErrorLabel.Text = errorMessage;
                return false;
            }
            else if (width < Desk.MIN_WIDTH)
            {
                WidthInputErrorLabel.Text = errorMessage;
                return false;
            }
            else
            {
                WidthInputErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkDrawers()
        {
            if(DrawerCombo.Text == "")
            {
                DrawerErrorLabel.Text = "Must select a value";
                return false;
            }
            else
            {
                DrawerErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkMaterial()
        {
            if (MaterialCombo.Text == "")
            {
                MaterialErrorLabel.Text = "Must select a material";
                return false;
            }
            else
            {
                MaterialErrorLabel.Text = "";
                return true;
            }
        }

        private bool checkRush()
        {
            if (RushCombo.Text == "")
            {
                RushErrorLabel.Text = "Must select a rush order option";
                return false;
            }
            else
            {
                RushErrorLabel.Text = "";
                return true;
            }
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

        private void RushCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialChanged(object sender, EventArgs e)
        {
            //MaterialCombo.Items.Remove("Select");
        }

        private void CheckValidation(object sender, EventArgs e)
        {
            bool nothing = validateFields();
        }
    }
}