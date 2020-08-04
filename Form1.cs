using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Button to go back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        //Button to go forward
        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        //Button to search the webpage in the textbox
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string webpageToBeSearched = textBox1.Text.Trim();
            webBrowser1.Navigate(webpageToBeSearched);
        }

        //Button to refresh the webpage
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        //Button to go home
        private void buttonHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
