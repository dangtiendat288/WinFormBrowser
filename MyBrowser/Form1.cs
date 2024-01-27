using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        Int32 result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Refreshes the web browser, reloading the current page.
        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        // Navigates the web browser to the Google homepage.
        private void homeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        // Navigates the web browser to the URL entered in the address text box.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Skips navigation if the address text box is empty.
            if (addrTextBox.Text.Equals("")) return;
            webBrowser1.Navigate(addrTextBox.Text);
        }

        // Performs addition based on the numbers entered in text boxes and displays the result.
        private void addButton_Click(object sender, EventArgs e)
        {
            // Skips addition if any of the number text boxes is empty.
            if (nbr1TextBox.Text.Equals("") || nbr2TextBox.Text.Equals("")) return;
            Int32 number1 = Convert.ToInt32(nbr1TextBox.Text);
            Int32 number2 = Convert.ToInt32(nbr2TextBox.Text);
            result = number1 + number2;
            resLabel.Text = result.ToString();
        }

        // Performs subtraction based on the numbers entered in text boxes and displays the result.
        private void subButton_Click(object sender, EventArgs e)
        {
            // Skips subtraction if any of the number text boxes is empty.
            if (nbr1TextBox.Text.Equals("") || nbr2TextBox.Text.Equals("")) return;
            Int32 number1 = Convert.ToInt32(nbr1TextBox.Text);
            Int32 number2 = Convert.ToInt32(nbr2TextBox.Text);
            result = number1 - number2;
            resLabel.Text = result.ToString();
        }

        // Performs multiplication based on the numbers entered in text boxes and displays the result.
        private void mulButton_Click(object sender, EventArgs e)
        {
            // Skips multiplication if any of the number text boxes is empty.
            if (nbr1TextBox.Text.Equals("") || nbr2TextBox.Text.Equals("")) return;
            Int32 number1 = Convert.ToInt32(nbr1TextBox.Text);
            Int32 number2 = Convert.ToInt32(nbr2TextBox.Text);
            result = number1 * number2;
            resLabel.Text = result.ToString();
        }

        // Performs division based on the numbers entered in text boxes and displays the result.
        private void divButton_Click(object sender, EventArgs e)
        {
            // Skips division if any of the number text boxes is empty.
            if (nbr1TextBox.Text.Equals("") || nbr2TextBox.Text.Equals("")) return;
            Int32 number1 = Convert.ToInt32(nbr1TextBox.Text);
            Int32 number2 = Convert.ToInt32(nbr2TextBox.Text);
            result = number1 / number2;
            resLabel.Text = result.ToString();
        }

        // Encrypts the text entered in the encryption text box using a web service.
        private void encButton_Click(object sender, EventArgs e)
        {
            // Skips encryption if the encryption text box is empty.
            if (encTextBox.Text.Equals("")) return;
            EncDecService.ServiceClient encService = new EncDecService.ServiceClient("BasicHttpsBinding_IService");
            string res = encService.Encrypt(encTextBox.Text);
            encResLabel.Text = res;
        }

        // Decrypts the text entered in the decryption text box using a web service.
        private void decButton_Click(object sender, EventArgs e)
        {
            // Skips decryption if the decryption text box is empty.
            if (decTextBox.Text.Equals("")) return;
            EncDecService.ServiceClient decService = new EncDecService.ServiceClient("BasicHttpsBinding_IService");
            string res = decService.Decrypt(decTextBox.Text);
            decResLabel.Text = res;
        }
    }
}
