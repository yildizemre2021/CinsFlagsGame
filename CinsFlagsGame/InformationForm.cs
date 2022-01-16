using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinsFlagsGame
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("* First select your five Land. But They must be neighboor to one of them.");
            listBox1.Items.Add("");
            listBox1.Items.Add("* Then wait for opponent to finish selecting his/her lands.");
            listBox1.Items.Add("");
            listBox1.Items.Add("* In the second stage of the game, shoot an opponent land which you predict");
            listBox1.Items.Add("  that his/her land.");
            listBox1.Items.Add("");
            listBox1.Items.Add("* If you shoot fifth of opponents lands first, You Win !");
            listBox1.Items.Add("");
            listBox1.Items.Add("* Good Luck !");
            listBox1.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
