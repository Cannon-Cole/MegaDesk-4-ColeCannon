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
                wr.WriteLine(HeightInput.Text + "," + WidthInput.Text + "," + MaterialCombo.SelectedItem + "," + RushCombo.SelectedItem + "," + DrawerUpDown.Value);
            }
            catch(Exception ex)
            {
                Console.WriteLine("File open issue: " + ex.Message);
            }
            finally
            {
                wr.Close();
            }
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