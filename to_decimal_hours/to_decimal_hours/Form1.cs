using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace to_decimal_hours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {


                var x = richTextBox1.Text;
                x = x.Replace(",", "");
                x = x.Replace("(", "");
                x = x.Replace(")", "");

                if (x.Contains("hr"))
                {

                    richTextBox1.Text = x;
                    var y = x.Split(' ');

                    var z = Math.Round(Convert.ToInt32(y[0]) + Convert.ToDecimal(y[2]) / 60, 2);

                    var xx = y[4] + " " + y[5];

                    richTextBox2.Text = textInfo.ToTitleCase(z + " hrs" + " " + xx);
                }
                else
                {
                    richTextBox1.Text = x;
                    var y = x.Split(' ');

                    var z = Math.Round(Convert.ToDecimal(y[0]) / 60, 2);

                    var xx = y[2] + " " + y[3];

                    richTextBox2.Text = textInfo.ToTitleCase(z + " hrs" + " " + xx);
                }
            }
            catch (Exception ex)
            {
                richTextBox2.Text = ex.Message;
            }
        }

    }
}
