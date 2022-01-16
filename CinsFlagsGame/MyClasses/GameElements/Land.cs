using System.Windows.Forms;

namespace CinsFlagsGame.MyClasses.GameElements
{
    public class Land : Button // Inherited Land has properties from Button.
    {
        private Player owner;  // Checking who is the owner of the Land when clicked.
        private byte coordX;  // assigning one of the 2D Land List index. 
        private byte coordY;  // assigning the other index.

        public Player Owner { get => owner; set => owner = value; } 
        public byte CoordX { get => coordX; set => coordX = value; }
        public byte CoordY { get => coordY; set => coordY = value; }
    }
}
