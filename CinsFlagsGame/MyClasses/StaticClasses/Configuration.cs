using CinsFlagsGame.MyClasses.GameElements;
using System.Drawing;
using System.Windows.Forms;

namespace CinsFlagsGame.MyClasses.StaticClasses
{
    public static class Configuration
    {
        public const int DEFAULT_LAND_SIZE = 50;
        public const int COUNT_LAND_XDIR = 6;
        public const int COUNT_LAND_YDIR = 5;
        public const int RIVER_HEIGHT = 60;
        public const int OWN_LAND = 5;
        public const string SELECT_LAND = "Pick Your Land On The Map";
        public const string HOST_TURN = "YOUR TURN SHOOT'EM UP ! !";
        public const string OPPONENT_TURN = "HOLD THEY'RE COMING !";

        public static string role;
        public static string serverIpep;

        public static void Start(Form form, Panel panel) // This method will run once when the Form_Load.
        {
            Game.State = 1; // First stage of the game is picking own lands.
            Player player1 = new Player("   Pirate", Color.Purple);
            player1.Turn = true;

            Player player2 = new Player("Okocha" + "", Color.Orange);
            player2.Turn = false;

            Game.Host = Configuration.role == "Server" ? player1 : player2;
            Game.Opponent = Configuration.role == "Server" ? player2 : player1;

            Game.HostPicture.Image = Configuration.role == "Server" ? global::CinsFlagsGame.Properties.Resources.pirate : global::CinsFlagsGame.Properties.Resources.okacha;
            Game.OpponentPicture.Image = Configuration.role == "Server" ? global::CinsFlagsGame.Properties.Resources.okacha : global::CinsFlagsGame.Properties.Resources.pirate;
            Game.UpNameLabel.Text = Game.Opponent.Name;
            Game.DownNameLabel.Text = Game.Host.Name;
            Game.DownIndicator.Text = Configuration.SELECT_LAND;

            Map.SetUpPlayGrounds(panel);

            Game.setLandAccess(false, Game.OpponentArena);

            panel.Width = DEFAULT_LAND_SIZE * COUNT_LAND_XDIR;
            panel.Height = (DEFAULT_LAND_SIZE * COUNT_LAND_YDIR) * 2 + RIVER_HEIGHT + 100;
            panel.Left = (form.Width - panel.Width) / 2;
            panel.Top = (form.Height - panel.Height) / 2;
        }
    }
}
