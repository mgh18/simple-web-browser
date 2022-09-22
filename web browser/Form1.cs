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
    public partial class Form1 : Form
    {
        System.Globalization.PersianCalendar per = new System.Globalization.PersianCalendar();
        DateTime datetime = new DateTime();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.dataSet1.history);
            // TODO: This line of code loads data into the 'dataSet1.favorite' table. You can move, or remove it, as needed.
            this.favoriteTableAdapter.Fill(this.dataSet1.favorite);
            datetime = DateTime.Now;
            label3.Text = per.GetYear(datetime) + "/" + per.GetMonth(datetime) + "/" + per.GetDayOfMonth(datetime);

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet1TableAdapters.historyTableAdapter his = new DataSet1TableAdapters.historyTableAdapter();
                his.InsertQuery(dataGridView2.RowCount.ToString(),textBox1.Text,textBox1.Text,textBox1.Text,label3.Text);

            }
            catch (Exception)
            {
                throw;
            }
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.favoriteTableAdapter fav = new DataSet1TableAdapters.favoriteTableAdapter();
            fav.InsertQuery(dataGridView1.RowCount.ToString(),textBox1.Text, textBox1.Text);
            MessageBox.Show("Added to Favorites");

        }
    }
}
