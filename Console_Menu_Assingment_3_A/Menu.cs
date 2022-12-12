using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Menu_Assingment_3_A
{
    public class Menu
    {
        public Menu(IEnumerable<string> items)
        {
            Items = items.ToArray();
        }


        public IReadOnlyList<string> Items { get; }

        public int SelectedIndex { get; private set; } = 0; // First Choice selected

        public string SelectedOption => SelectedIndex != -1 ? Items[SelectedIndex] : null;


        public void MoveUp() => SelectedIndex = Math.Max(SelectedIndex - 1, 0);

        public void MoveDown() => SelectedIndex = Math.Min(SelectedIndex + 1, Items.Count - 1);


        public static string MenuGenerator(string Option1, string Option2, string Option3)
        {
            var menu = new Menu(new string[] { Option1, Option2, Option3});
            var menuPainter = new ConsoleMenuPainter(menu);

            bool done = false;

            do
            {
                menuPainter.Paint(8, 5);

                var keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: menu.MoveUp(); break;
                    case ConsoleKey.DownArrow: menu.MoveDown(); break;
                    case ConsoleKey.Enter: done = true; break;
                }
            }
            while (!done);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            return menu.SelectedOption;
        }
        public static string MenuGenerator(string Option1, string Option2, string Option3, string Option4)
        {
            var menu = new Menu(new string[] { Option1, Option2, Option3, Option4 });
            var menuPainter = new ConsoleMenuPainter(menu);

            bool done = false;

            do
            {
                menuPainter.Paint(8, 5);

                var keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: menu.MoveUp(); break;
                    case ConsoleKey.DownArrow: menu.MoveDown(); break;
                    case ConsoleKey.Enter: done = true; break;
                }
            }
            while (!done);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return menu.SelectedOption;
        }
    }
}
