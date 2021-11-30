using LoginSysten;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika
{
    public partial class CreateGroup : Form
    {
        Config db = new();
        public CreateGroup()
        {
            InitializeComponent();
            db.Connect("Praktika");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `student_group` where group_name='" + textBox1.Text + "'");

            if (db.Count() == 1)
            {

                MessageBox.Show("Tokia grupė jau užimta");
                textBox1.Text = "";
            }

            else
            {
                db.Execute("INSERT INTO `student_group` (`group_id`, `group_name`) " +
                    "VALUES (NULL, '" + textBox1.Text + "');");

                MessageBox.Show("Grupė sėkmingai sukurta");
                textBox1.Text = "";

                try
                {
                    db.Filldatagrid("Select group_name FROM `student_group`", dataGridView1);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
            
        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            try
            {
                db.Filldatagrid("Select group_name FROM `student_group`", dataGridView1);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `student_group` where group_name='" + textBox1.Text + "'");

            if (db.Count() == 0)
            {
                MessageBox.Show("Tokios grupės nėra");
                textBox1.Text = "";
            }

            else
            {
                db.Execute("DELETE FROM `student_group` WHERE `group_name`='" + textBox1.Text + "'");

                MessageBox.Show("Grupė sėkmingai pašalinta");
                textBox1.Text = "";

                try
                {
                    db.Filldatagrid("Select group_name FROM `student_group`", dataGridView1);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }
    }
}
