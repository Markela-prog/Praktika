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
    public partial class CreateSubject : Form
    {
        Config db = new();
        public int user;
        public CreateSubject()
        {
            InitializeComponent();
            db.Connect("praktika");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ID(int id)
        {
            user = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `subject` where subject_name='" + textBox1.Text + "'");

            if (db.Count() == 1)
            {

                MessageBox.Show("Toks dėstomas dalykas jau egzistuoja");
                textBox1.Text = "";
            }

            else
            {
                db.Execute("INSERT INTO `subject` (`subject_id`, `subject_name`) " +
                    "VALUES (NULL, '" + textBox1.Text + "');");

                MessageBox.Show("Dalykas sėkmingai sukurtas");
                textBox1.Text = "";

                filldata();


            }
        }

        private void CreateSubject_Load(object sender, EventArgs e)
        {
            this.dataGridView2.Columns["Grupės_Dalyko_id"].Visible = false;
            this.dataGridView2.Columns["Grupės_dalykai"].Visible = false;
            this.dataGridView3.Columns["Dėstytojo_Dalykai"].Visible = false;
            filldata();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `subject` where subject_id='" + textBox2.Text + "'");

            if (db.Count() == 0)
            {
                MessageBox.Show("Tokio dalyko nėra");
                textBox2.Text = "";
            }

            else
            {
                db.Execute("DELETE FROM `subject` WHERE `subject_id`='" + textBox2.Text + "'");

                MessageBox.Show("Dalykas sėkmingai pašalintas");
                textBox2.Text = "";

                filldata();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `subject` where subject_id='" + textBox3.Text + "'");

            if (db.Count() == 0)
            {
                MessageBox.Show("Tokio dalyko nėra");
                textBox3.Text = "";
            }
            else
            {
                db.ExecuteSelect("SELECT * FROM `student_group` where group_id='" + textBox4.Text + "'");

                if (db.Count() == 0)
                {
                    MessageBox.Show("Tokios grupės nėra");
                    textBox4.Text = "";
                }
                else
                {
                    filldata();
                    db.Execute("INSERT INTO `group_subject` (`group_subject_id`, `subject_id`, `group_id`) " +
                    "VALUES (NULL, '" + textBox3.Text + "', '" + textBox4.Text + "');");

                    MessageBox.Show("Dalykas sėkmingai priskirtas grupei");
                    textBox3.Text = "";
                    textBox4.Text = "";
                }

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGridView3.Columns["Dėstytojo_Dalykai"].Visible = false;

            this.dataGridView3.Columns["Dėstytojo_id"].Visible = true;
            this.dataGridView3.Columns["Dėstytojo_vardas"].Visible = true;
            this.dataGridView3.Columns["Dėstytojo_pavardė"].Visible = true;

            try
            {
                db.Filldatagrid("Select lector_id, FirstName, LastName FROM `lector`", dataGridView3);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.dataGridView3.Columns["Dėstytojo_Dalykai"].Visible = true;

            this.dataGridView3.Columns["Dėstytojo_id"].Visible = false;
            this.dataGridView3.Columns["Dėstytojo_vardas"].Visible = false;
            this.dataGridView3.Columns["Dėstytojo_pavardė"].Visible = false;

            try
            {
                db.Filldatagrid("Select subject.subject_name FROM `lector_subject`" +
                    "INNER JOIN subject ON lector_subject.subject_id=subject.subject_id WHERE lector_id='" + textBox7.Text + "'", dataGridView3);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void filldata()
        {
            try
            {
                db.Filldatagrid("Select * FROM `subject`", dataGridView1);
                db.Filldatagrid("Select * FROM `student_group`", dataGridView2);
                db.Filldatagrid("Select lector_id, FirstName, LastName FROM `lector`", dataGridView3);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `lector` where lector_id='" + textBox6.Text + "'");

            if (db.Count() == 0)
            {
                MessageBox.Show("Tokio dėstytojo nėra");
                textBox3.Text = "";
            }
            else
            {
                db.ExecuteSelect("SELECT * FROM `group_subject` where group_subject_id='" + textBox5.Text + "'");

                if (db.Count() == 0)
                {
                    MessageBox.Show("Tokio grupės dalyko nėra");
                    textBox7.Text = "";
                }

                else
                {
                    int subid;
                    db.ExecuteSelect("SELECT subject_id FROM `group_subject` where group_subject_id='" + textBox5.Text + "'");
                    subid = Int32.Parse(db.Results(0, "subject_id"));

                    db.ExecuteSelect("SELECT subject_id FROM lector_subject where subject_id='" + subid + "' AND lector_id ='" + textBox6.Text + "'");

                    if(db.Count()==1)
                    {
                        db.Execute("UPDATE group_subject SET lector_id='" + textBox6.Text + "' where group_subject_id='" + textBox5.Text + "'");

                        MessageBox.Show("Dėstytojas sėkmingai priskirtas prie grupės dalyko");
                        textBox6.Text = "";
                        textBox5.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Šis dėstytojas nedėsto šio dalyko");
                    }
                    
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns["Grupės_Dalyko_id"].Visible = true;
            this.dataGridView2.Columns["Grupės_Dalykai"].Visible = true;

            this.dataGridView2.Columns["Grupės_id"].Visible = false;
            this.dataGridView2.Columns["Grupės"].Visible = false;

            try
            {
                db.Filldatagrid("Select subject.subject_name, group_subject_id FROM `group_subject`" +
                    "INNER JOIN subject ON group_subject.subject_id=subject.subject_id WHERE group_id='" + textBox8.Text + "'", dataGridView2);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Columns["Grupės_Dalykai"].Visible = false;
            this.dataGridView2.Columns["Grupės_id"].Visible = true;
            this.dataGridView2.Columns["Grupės"].Visible = true;
            this.dataGridView2.Columns["Grupės_Dalyko_id"].Visible = false;
            try
            {
                db.Filldatagrid("Select * FROM `student_group`", dataGridView2);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}