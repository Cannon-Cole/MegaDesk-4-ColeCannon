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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            StreamReader re = new StreamReader(@"C: \Users\Cliff\source\repos\MegaDesk-4-ColeCannon\quotes.txt");
            SearchDisplay.Text = "";

            try
            {
                while (!re.EndOfStream)
                {
                    string quote = re.ReadLine();
                    string[] quoteProperties = quote.Split(',');
        
                        SearchDisplay.Text += "Height: " + quoteProperties[0] + " Width: " + quoteProperties[1] + " Material: " + quoteProperties[2] + " Rush: " + quoteProperties[3] + " Drawers: " + quoteProperties[4] + "\n";                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File read issue: " + ex.Message);
            }
            finally
            {
                re.Close();
            }
        }

        private void ViewQuotesBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}