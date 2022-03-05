namespace modul2_1302200049
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay2.Text = "+";
            txtDisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            } 
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text != "0")
            {
                txtDisplay.Text += "0";
            }
        }

        private void buttonhasil_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(txtDisplay.Text);
            {
                
             txtDisplay.Text = Convert.ToString(bil1 + bil2);
                
            }
            opr_selesai = false;
   
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            bil1 = 0;
            bil2 = 0;
            txtDisplay2.Text = " ";
        }
    }
}
