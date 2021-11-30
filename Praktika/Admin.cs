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
    
    public partial class Admin : Form
    {
        Config db = new Config();
        public int user;
        public Admin()
        {
            InitializeComponent();
            db.Connect("praktika");
        }

        public void ID(int id)
        {
            user = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registracija = new Registracija();
            registracija.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var group = new CreateGroup();
            group.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var dalykas = new CreateSubject();
            dalykas.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var edit = new EditUsers();
            edit.Show();
        }
    }
}
