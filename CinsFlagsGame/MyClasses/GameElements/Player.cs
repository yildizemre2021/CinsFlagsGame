using System.Drawing;

namespace CinsFlagsGame.MyClasses.GameElements
{
    public class Player
    {
        private string name;
        private Color flagColor;
        private int maxOwnLand = 5;
        private int shootedLand = 0;
        private bool turn;
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
