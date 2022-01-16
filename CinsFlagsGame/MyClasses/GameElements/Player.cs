using System.Drawing;

namespace CinsFlagsGame.MyClasses.GameElements
{
    public class Player
    {
        private string name;
        private Color flagColor;
        private int maxOwnLand = 5;  // Players have 5 Land area when the war game starts.
        private int shootedLand = 0; // this integer is for checking the Final state of the game. 
        private bool turn;  // Players shoot the correspondence area turn by turn.

        public Player(string name, Color flagColor)
        {
            this.name = name;
            this.flagColor = flagColor;
        }

        public string Name { get => name; set => name = value; }
        public Color FlagColor { get => flagColor; set => flagColor = value; }
        public bool Turn { get => turn; set => turn = value; }
        public int MaxOwnLand { get => maxOwnLand; set => maxOwnLand = value; }
        public int ShootedLand { get => shootedLand; set => shootedLand = value; }
    }
}
