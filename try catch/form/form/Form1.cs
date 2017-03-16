using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try // try this code below and if there is an error with it then it's going to look for its catch statement 
            {
                string[] names = new string[2];
                string s = names[2]; // this will create an array since computers start their counting at 0

            } 
            catch (Exception ex)
            {
                //MessageBox.Show("There was an error");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Your code is done "); // this code will run if we have a error or not (default)
            }
            }


    }
}
