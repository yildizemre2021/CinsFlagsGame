using CinsFlagsGame.MyClasses.GameElements;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CinsFlagsGame.MyClasses.StaticClasses
{
    public static class Map
    {
        // with SetMap() the map is parameterized. We can simple change map size with parameters.
        public static void SetMap(List<List<Land>> map, int sizeX, int sizeY, int offset, Panel panel, int reflect = 0)
        {
            for (int i = 0; i < sizeY; i++)
            {
                map.Add(new List<Land>());

                for (int k = 0; k < sizeX; k++)
                {
                    map[i].Add(new Land());
                    map[i][k].TabStop = false; // cancel unnecessary focusing on button(Land).
                    map[i][k].CoordX = (byte)k; // set 2D list index. We'll use this two bytes in tcp networking.
                    map[i][k].CoordY = (byte)i; // 

                    panel.Controls.Add(map[i][k]);
                    map[i][k].Size = new Size(Configuration.DEFAULT_LAND_SIZE, Configuration.DEFAULT_LAND_SIZE);

                    if (reflect > 0) // flipping sides because opponent sees playground oppositely
                        map[i][k].Location = new Point((sizeY - i - 1) * Configuration.DEFAULT_LAND_SIZE, (sizeX - k - 1) * Configuration.DEFAULT_LAND_SIZE + offset);
                    else
                        map[i][k].Location = new Point(i * Configuration.DEFAULT_LAND_SIZE, k * Configuration.DEFAULT_LAND_SIZE + offset);

                    map[i][k].Click += (sender, e) => { Form2.Land_Clicked_Event(sender, e); }; // Lands click event function
                }
            }
        }

        public static void SetUpPlayGrounds(Panel panel)  // Setting Parameterized Map 
        {
            Map.SetMap(Game.OpponentArena, Configuration.COUNT_LAND_YDIR, Configuration.COUNT_LAND_XDIR, 0, panel, 1);

            int offset = (Configuration.COUNT_LAND_YDIR * Configuration.DEFAULT_LAND_SIZE) + Configuration.RIVER_HEIGHT;
            Map.SetMap(Game.HostArena, Configuration.COUNT_LAND_YDIR, Configuration.COUNT_LAND_XDIR, offset, panel);
        }

    }
}
