using CinsFlagsGame.MyClasses.GameElements;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace CinsFlagsGame.MyClasses.StaticClasses
{
    public static class Game
    {
        public static int State; // Must track the Game States {Form_Load, 1, 2, Final}
        public static Player Host;
        public static Player Opponent;
        public static List<List<Land>> HostArena = new List<List<Land>>(); //  PlayGround of Host Player. 2D List data structure.
        public static List<List<Land>> OpponentArena = new List<List<Land>>(); // PlayGround of Opponent. Lands inherited from  WinForm Button.

        // GUI components.
        public static ListBox ChatWindow;
        public static PictureBox HostPicture;
        public static PictureBox OpponentPicture;
        public static Label UpNameLabel;
        public static Label DownNameLabel;
        public static Label UpIndicator;
        public static Label DownIndicator;

        public static void setLandAccess(bool b, List<List<Land>> lands) // Disabling List of Buttons(Lands)
        {
            foreach (List<Land> l in lands)
                foreach (var item in l)
                {
                    item.Enabled = b;
                }
        }

        public static void setLandAccess(bool b, Land land)
        {
            land.Enabled = b;
        }

        public static void PickLand(Land land, byte[] data) // Select 5 lands from own playground (Game State 1) 
        {
            switch (Game.Host.MaxOwnLand)
            {
                case 5:
                    land.Owner = Host;
                    land.BackColor = land.Owner.FlagColor;
                    Game.Host.MaxOwnLand -= 1;
                    Game.setLandAccess(false, land);
                    TcpGame.Send(data, 2);
                    break;
                case 0:
                    break;
                default:
                    if (LandNeighboorControl(land))
                    {
                        land.Owner = Host;
                        land.BackColor = land.Owner.FlagColor;
                        Game.Host.MaxOwnLand -= 1;
                        Game.setLandAccess(false, land);
                        TcpGame.Send(data, 2);
                    }
                    break;
            }

            if (Host.MaxOwnLand == 0 && Opponent.MaxOwnLand == 0 && Game.State == 1)
            {
                Game.State = 2;
                Game.setLandAccess(false, Game.HostArena);
                Game.setLandAccess(true, Game.OpponentArena);
                if (Configuration.role == "Server")
                {
                    Game.DownIndicator.Text = Configuration.HOST_TURN;
                }
                else
                {
                    Game.DownIndicator.Text = "";
                    Game.UpIndicator.Text = Configuration.OPPONENT_TURN;
                }
            }
        }

        private static bool LandNeighboorControl(Land land) // When selecting own five lands, the rule is that all selected lands are neighboor with one of them.
        {
            int x = land.CoordX;
            int y = land.CoordY;

            if (x + 1 < 5 && Game.HostArena[y][x + 1].Owner == Host)
                return true;
            if (x - 1 >= 0 && Game.HostArena[y][x - 1].Owner == Host)
                return true;
            if (y + 1 < 6 && Game.HostArena[y + 1][x].Owner == Host)
                return true;
            if (y - 1 >= 0 && Game.HostArena[y - 1][x].Owner == Host)
                return true;
            return false;
        }

        public static void ShootLand(Land land, byte[] data) // Shooting the opponents playground blindly.
        {
            if (Host.Turn == true)
            {
                if (land.Owner == Opponent)  // shooted
                {
                    Game.playBombSound();
                    Host.ShootedLand++;
                    land.Owner = Host;
                    land.BackColor = land.Owner.FlagColor;
                }
                else // not shooted the right one.
                {
                    Game.playFailedSound();
                    land.TextAlign = ContentAlignment.MiddleCenter;
                    land.Font = new Font("Microsoft Sans Serif", 30);
                    land.ForeColor = Host.FlagColor;
                    land.Text = "X";
                }
                Game.Host.Turn = false;
                Game.UpIndicator.Text = Configuration.OPPONENT_TURN;
                Game.DownIndicator.Text = "";
                Game.setLandAccess(false, land);

                TcpGame.Send(data, 2);

                if (Host.ShootedLand == 5)
                {
                    MessageBox.Show("You Win !", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TcpGame.client.Close();
                    System.Environment.Exit(0);
                }
            }
        }

        public static void ReceiveMessage(byte[] data, int recv) // Critical method for receiving messages from other client with tcp/ip protocol.
        {
            if (recv == 2) // Then this is the communucation for land clicking. The below one is for chatting (recv > 2)
            {
                if (Game.State == 1) // sending the picked lands to other client.
                {
                    Land land = Game.OpponentArena[data[0]][data[1]];
                    land.Owner = Game.Opponent;
                    Game.Opponent.MaxOwnLand -= 1;
                    Game.DownIndicator.Text = Configuration.SELECT_LAND;
                }
                if (Game.State == 2)  // sending the shooted land to client.
                {
                    Game.Host.Turn = true;
                    Game.DownIndicator.Text = Configuration.HOST_TURN;
                    Game.UpIndicator.Text = "";

                    Land land = Game.HostArena[data[0]][data[1]];

                    if (land.Owner == Game.Host)
                    {
                        Game.playBombSound();
                        land.Owner = Game.Opponent;
                        land.BackColor = land.Owner.FlagColor;
                        Game.Opponent.ShootedLand++;
                    }
                    else
                    {
                        Game.playFailedSound();
                        land.Enabled = false;
                        land.Font = new Font("Microsoft Sans Serif", 30);
                        land.ForeColor = Game.Opponent.FlagColor;
                        land.TextAlign = ContentAlignment.MiddleCenter;
                        land.Text = "X";
                    }
                }
                if (Game.Host.MaxOwnLand == 0 && Game.Opponent.MaxOwnLand == 0 && Game.State == 1) // transition to Game State 2. Start to shoot opponent.
                {
                    Game.State = 2;
                    Game.setLandAccess(false, Game.HostArena);
                    Game.setLandAccess(true, Game.OpponentArena);

                    if (Configuration.role == "Server")
                    {
                        Game.DownIndicator.Text = Configuration.HOST_TURN;
                        Game.UpIndicator.Text = "";
                    }
                    else
                    {
                        Game.UpIndicator.Text = Configuration.OPPONENT_TURN;
                        Game.DownIndicator.Text = "";
                    }
                }

                if (Game.Opponent.ShootedLand == 5)
                {
                    MessageBox.Show("You Lose Baby !", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TcpGame.client.Close();
                    System.Environment.Exit(0);
                }
            }

            if (recv > 2)  // this is for chating data transfer. The other recv is (recv = 2) for clicked Lands.
            {
                string stringData = Encoding.UTF8.GetString(data, 0, recv);
                Game.ChatWindow.Items.Add("-- " + Game.Opponent.Name + " --    " + stringData);
            }
        }

        public static void playBombSound()
        {
            SoundPlayer bombSound = new SoundPlayer(CinsFlagsGame.Properties.Resources.bomb);
            bombSound.Play();
        }
        public static void playFailedSound()
        {
            SoundPlayer failedSound = new SoundPlayer(Properties.Resources.failed);
            failedSound.Play();
        }
        public static void playStartSound()
        {
            SoundPlayer startSound = new SoundPlayer(Properties.Resources.start);
            startSound.Play();
        }

    }
}
