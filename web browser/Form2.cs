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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.dataSet1.history);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to delete this record of your history search?","Delete History",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    DataSet1TableAdapters.historyTableAdapter his=new DataSet1TableAdapters.historyTableAdapter();
                    his.DeleteQuery(textBox1.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
