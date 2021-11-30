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
    public partial class EditUsers : Form
    {
        Config db = new ();
        public EditUsers()
        {
            InitializeComponent();
            db.Connect("praktika");
        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `student` where student_id='" + textBox1.Text + "'");
            if (db.Count() == 0)
            {
                MessageBox.Show("Tokio studento nėra");
                textBox1.Text = "";
            }
            else
            {
                int userid;
                db.ExecuteSelect("SELECT user_id FROM `student` WHERE student_id='" + textBox1.Text + "'");

                userid = Int32.Parse(db.Results(0,"user_id"));

                db.Execute("DELETE FROM `student` WHERE `student_id`='" + textBox1.Text + "'");
                db.Execute("DELETE FROM `user` WHERE user_id='" + userid + "'");

                MessageBox.Show("Studentas pašalintas");

                try
                {
                    db.Filldatagrid("Select student.student_id, student.FirstName, student.LastName, student_group.group_name FROM `student`" +
                    "INNER JOIN student_group ON student.group_id=student_group.group_id", dataGridView1);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `lector` where lector_id='" + textBox2.Text + "'");
            if (db.Count() == 0)
            {
                MessageBox.Show("Tokio dėstytojo nėra");
                textBox2.Text = "";
            }
            else
            {
                int userid;
                db.ExecuteSelect("SELECT user_id FROM `lector` WHERE lector_id='" + textBox2.Text + "'");

                userid = Int32.Parse(db.Results(0, "user_id"));

                db.Execute("DELETE FROM `lector` WHERE `lector_id`='" + textBox2.Text + "'");
                db.Execute("DELETE FROM `user` WHERE user_id='" + userid + "'");
                db.Execute("DELETE FROM `lector_subject` WHERE lector_id='" + textBox2.Text + "'");

                MessageBox.Show("Dėstytojas pašalintas");

                try
                {
                    db.Filldatagrid("Select lector_id, FirstName, LastName FROM `lector`", dataGridView3);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT subject_id FROM `subject` where subject_id='" + textBox4.Text + "'");
            if (db.Count() == 0)
            {
                MessageBox.Show("Tokio dalyko nėra");
            }
            else
            {
                db.ExecuteSelect("SELECT * FROM `lector` where lector_id='" + textBox3.Text + "'");

                if (db.Count() == 0)
                {
                    MessageBox.Show("Tokio dėstytojo nėra");
                    textBox3.Text = "";
                }
                else
                {
                    db.ExecuteSelect("SELECT lector_subject_id FROM `lector_subject` " +
                        "WHERE lector_id='" + textBox3.Text + "' AND subject_id='" + textBox4.Text + "'");
                    if (db.Count() == 0)
                    {
                        db.Execute("INSERT INTO `lector_subject` (`lector_subject_id`, `lector_id`, `subject_id`) " +
                                    "VALUES (NULL, '" + textBox3.Text + "', '" + textBox4.Text + "');");

                        MessageBox.Show("Dalykas priskirtas dėstytojui");
                    }
                    else
                    {
                        MessageBox.Show("Dėstytojas jau dėsto šį dalyką");
                    }
                }
            }
            
        }

        public void filldata()
        {
            try
            {
                db.Filldatagrid("Select student.student_id, student.FirstName, student.LastName, student_group.group_name FROM `student`" +
                    "INNER JOIN student_group ON student.group_id=student_group.group_id", dataGridView1);
                db.Filldatagrid("Select lector_id, FirstName, LastName FROM `lector`", dataGridView3);
                db.Filldatagrid("Select * FROM `subject`", dataGridView2);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }

}
