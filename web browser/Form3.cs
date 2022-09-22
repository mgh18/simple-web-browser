using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_browser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.passBank' table. You can move, or remove it, as needed.
            this.passBankTableAdapter.Fill(this.dataSet1.passBank);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record from your Password bank?", "Delete from Passwords", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataSet1TableAdapters.passBankTableAdapter pas = new DataSet1TableAdapters.passBankTableAdapter();
                    pas.DeleteQuery(textBox1.Text);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
