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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.favorite' table. You can move, or remove it, as needed.
            this.favoriteTableAdapter.Fill(this.dataSet1.favorite);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to delete this record from your favorites?","Delete from Favorites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataSet1TableAdapters.favoriteTableAdapter fav=new DataSet1TableAdapters.favoriteTableAdapter();
                    fav.DeleteQuery(textBox1.Text);
                }
            }   
            catch (Exception)
            {
                throw;
            }
        }
    }
}
