using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Newproj
{
    public partial class projectq : Form
    {
        public projectq()
        {
            InitializeComponent();
        }
        db1DataContext db = new db1DataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|data.mdf;Integrated Security=True;User Instance=True");

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    projg.DataSource = from x in db.Projects select x;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    projg.DataSource = from x in db.Projects
                                       where x.PNo > int.Parse(t1.Text)
                                       select x;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    projg.DataSource = from x in db.Projects
                                       where x.PNo < int.Parse(t1.Text)
                                       select x;
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    projg.DataSource = from x in db.Projects
                                       where x.SupNo > int.Parse(t1.Text)
                                       select x;
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    projg.DataSource = from x in db.Projects
                                       where x.SupNo < int.Parse(t1.Text)
                                       select x;
                }
                if (comboBox1.SelectedIndex == 5)
                {
                    projg.DataSource = from x in db.Projects
                                       where x.StNo > int.Parse(t1.Text)
                                       select x;
                }
                if (comboBox1.SelectedIndex == 6)
                {
                    projg.DataSource = from x in db.Projects
                                       where x.StNo < int.Parse(t1.Text)
                                       select x;
                }
                if (comboBox1.SelectedIndex == 7)
                {
                    projg.DataSource = from x in db.Projects
                                       where x.Name == t1.Text
                                       select x;
                }
            }
            catch
            {
                MessageBox.Show("enter a valid data");
               
            }

        }

        private void projectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void projectq_Load(object sender, EventArgs e)
        {
            projg.DataSource = from x in db.Projects
                               select x;
            comboBox1.Items.Add("All");//0
            comboBox1.Items.Add("PNo>");//1
            comboBox1.Items.Add("PNo<");//2
            comboBox1.Items.Add("SupNo>");//3
            comboBox1.Items.Add("SupNo<");
            comboBox1.Items.Add("StNo>");
            comboBox1.Items.Add("StNo<");
            comboBox1.Items.Add("Name is :");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
