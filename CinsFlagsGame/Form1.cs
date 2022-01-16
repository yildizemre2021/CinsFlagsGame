using CinsFlagsGame.MyClasses.StaticClasses;
using System;
using System.Windows.Forms;

namespace CinsFlagsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e) // starting server to listen.
        {
            Configuration.role = "Server";
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)  // start to connect client with game server.
        {
            Configuration.role = "Client";
            Configuration.serverIpep = textBox1.Text;
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

    }
}
