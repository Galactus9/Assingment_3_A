using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Menu_Assingment_3_A
{
    public class ConsoleMenuPainter
    {
        readonly Menu menu;

        public ConsoleMenuPainter(Menu menu)
        {
            this.menu = menu;
        }

        public void Paint(int x, int y)
        {
            for (int i = 0; i < menu.Items.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);

                var color = menu.SelectedIndex == i ? ConsoleColor.DarkCyan : ConsoleColor.Gray;

                Console.ForegroundColor = color;
                Console.WriteLine(menu.Items[i]);
            }
        }
    }
}
