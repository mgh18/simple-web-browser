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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.passBank' table. You can move, or remove it, as needed.
            this.passBankTableAdapter.Fill(this.dataSet1.passBank);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1TableAdapters.passBankTableAdapter ps =new DataSet1TableAdapters.passBankTableAdapter();
                ps.InsertQuery(dataGridView1.RowCount.ToString(), textBox3.Text, textBox4.Text, textBox5.Text, textBox2.Text, textBox1.Text);
                MessageBox.Show("Account Added!","ADD Account!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Adding Accaunt!");
                throw;
            }
        }
    }
}
