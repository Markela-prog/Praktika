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
    public partial class Lector : Form
    {
        Config db = new();
        public int user;
        public Lector()
        {
            InitializeComponent();
            db.Connect("praktika");
        }

        public void ID(int id)
        {
            user = id;
        }
        private void Lector_Load(object sender, EventArgs e)
        {
            int lectorid;
            db.ExecuteSelect("SELECT lector.lector_id FROM `group_subject` " +
                "INNER JOIN lector ON group_subject.lector_id=lector.lector_id WHERE user_id='" + user + "'");
            lectorid = Int32.Parse(db.Results(0, "lector_id"));


            try
            {
                db.Filldatagrid("Select group_subject.group_subject_id, student_group.group_name, subject.subject_name FROM `group_subject`" +
                "INNER JOIN student_group ON group_subject.group_id=student_group.group_id " + 
                "INNER JOIN subject ON group_subject.subject_id=subject.subject_id WHERE lector_id='" + lectorid +"'", dataGridView1);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("Select group_subject_id FROM group_subject WHERE group_subject_id='" + textBox1.Text + "'");
            if (db.Count() == 1)
            {
                int groupid;
                db.ExecuteSelect("SELECT group_id FROM group_subject WHERE group_subject_id='" + textBox1.Text + "'");

                groupid = Int32.Parse(db.Results(0, "group_id"));


                try
                {
                    db.Filldatagrid("Select student_id, FirstName, LastName FROM `student`" +
                    "WHERE group_id='" + groupid + "'", dataGridView2);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Tokio dalyko nėra");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("Select student_id FROM student WHERE student_id='" + textBox2.Text +"'");

            if (db.Count() == 1)
            {

                try
                {
                    db.Filldatagrid("Select mark_id, marktype, mark FROM `marks`" +
                    "WHERE student_id='" + textBox2.Text + "' AND group_subject_id='" + textBox1.Text + "'", dataGridView3);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Tokio studento nėra");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox5.Text) < 1 || Int32.Parse(textBox5.Text) > 10)
                MessageBox.Show("Įvesktie pažymį nuo 1 iki 10");
            else
            {
                db.Execute("INSERT INTO `marks` (`mark_id`, `marktype`, `mark`, `student_id` , `group_subject_id`) " +
                    "VALUES (NULL, '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox2.Text + "', '" + textBox1.Text + "');");
                MessageBox.Show("Pažymys įvestas");

                try
                {
                    db.Filldatagrid("Select mark_id, marktype, mark FROM `marks`" +
                    "WHERE student_id='" + textBox2.Text + "' AND group_subject_id='" + textBox1.Text + "'", dataGridView3);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT mark_id from marks where mark_id='" + textBox3.Text +"'");

            if (db.Count() == 1)
            {
                if (Int32.Parse(textBox6.Text) < 1 || Int32.Parse(textBox6.Text) > 10)
                    MessageBox.Show("Įvesktie pažymį nuo 1 iki 10");
                else
                {
                    db.Execute("UPDATE marks SET mark='" + textBox6.Text + "' where mark_id='" + textBox3.Text + "'");
                    MessageBox.Show("Pažymys pakeistas");

                    try
                    {
                        db.Filldatagrid("Select mark_id, marktype, mark FROM `marks`" +
                    "WHERE student_id='" + textBox2.Text + "' AND group_subject_id='" + textBox1.Text + "'", dataGridView3);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }

            else
            {
                MessageBox.Show("Tokio pažymio nėra");
            }
        }
    }
}
