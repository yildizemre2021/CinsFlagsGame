using System.Windows.Forms;

namespace CinsFlagsGame.MyClasses.GameElements
{
    public class Land: Button
    {
        private Player owner;
        private byte coordX;
        private byte coordY;

        public Player Owner { get => owner; set => owner = value; }
        public byte CoordX { get => coordX; set => coordX = value; }
        public byte CoordY { get => coordY; set => coordY = value; }
    }
}
