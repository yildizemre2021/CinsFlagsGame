using CinsFlagsGame.MyClasses.GameElements;
using CinsFlagsGame.MyClasses.StaticClasses;
using System;
using System.Text;
using System.Windows.Forms;

namespace CinsFlagsGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // some of the visual components of game. 
            Game.ChatWindow = listBox1;
            Game.HostPicture = this.pictureBox2;
            Game.OpponentPicture = this.pictureBox1;
            Game.UpNameLabel = this.UpNameLabel;
            Game.DownNameLabel = this.DownNameLabel;
            Game.UpIndicator = this.UpIndicator;
            Game.DownIndicator = this.DownIndicator;

            Configuration.Start(this, panel1); // Preparing the gui details and launching the map.

            TcpGame.Initialize(); // setting up the tcp/ip server and client together that is asynchronous and threaded.
        }

        internal static void Land_Clicked_Event(object sender, EventArgs e) // All the Land(button) clicked events start in this method.
        {
            Land land = (Land)sender;
            byte[] data = new byte[] { land.CoordY, land.CoordX }; // two bytes of Land data is needed for communucation of clients.

            switch (Game.State)  
            {
                case 1: // In game state 1, players will select their own lands.
                    Game.PickLand(land, data);
                    break;
                case 2: // In game state 2, players will try to shoot opponents unvisible lands with mouse click.
                    Game.ShootLand(land, data);
                    break;
            }
        }
      
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            TcpGame.client.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // assigning "Enter" key to write to chat ListBox.
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Game.ChatWindow.Items.Add("-- " + Game.Host.Name + " --    " + textBox2.Text);
                byte[] message = Encoding.UTF8.GetBytes(textBox2.Text + "   "); // space chars take guarantee that recv > 2 (bytes), because recv = 2 when Land communication.
                textBox2.Clear();
                TcpGame.Send(message, message.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformationForm info = new InformationForm();
            info.ShowDialog();
        }
    }
}
