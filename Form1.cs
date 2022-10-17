using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAT_BUT_WINDOWS
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {
            
           
            //getting the sum of input values in order to get a percentage
           
            // algorithm to get the final output
            try
            {
                //list of input values
                List<float> values = new List<float>();
                values.Add(float.Parse(txtYear1.Text));
                values.Add(float.Parse(txtYear2.Text));
                values.Add(float.Parse(txtYear3.Text));
                values.Add(float.Parse(txtYear4.Text));
                values.Add(float.Parse(txtYear5.Text));
                values.Add(float.Parse(txtYear6.Text));
                values.Add(float.Parse(txtYear7.Text));
                values.Add(float.Parse(txtYear8.Text));
                values.Add(float.Parse(txtYear9.Text));
                values.Add(float.Parse(txtYear10.Text));
                lblOutput.Text = "";
                float value = 0;
                float sum = values.Sum();
                value = (sum / 100);
                
                float finalValue = value * float.Parse(txtUpfront.Text);
                float dmf = float.Parse(txtUpfront.Text) - finalValue;
                float saved = float.Parse(txtUpfront.Text) - dmf;
                lblOutput.Text = ("Your cost after 10 years will be $" + (dmf));
                lblSaved.Text = ("This means you will keep $" + (saved));
            }
           // safety net for incorrect inputs
            catch
            {
                MessageBox.Show(" Please Enter all values. If contract ends before 10 years input 0 in all boxes after your contract ends");
            }
            


        }
        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calculate();
        }
        //creating a new quote by wiping all inputs and outputs
        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            txtUpfront.Text = "";
            txtYear1.Text = "";
            txtYear2.Text = "";
            txtYear3.Text = "";
            txtYear4.Text = "";
            txtYear5.Text = "";
            txtYear6.Text = "";
            txtYear7.Text = "";
            txtYear8.Text = "";
            txtYear9.Text = "";
            txtYear10.Text = "";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
