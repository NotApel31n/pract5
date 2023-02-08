using System;
using System.IO;
using System.Collections.Generic;
namespace pr5
{
    public class MenuAndSubMenu
    {

        public int price;
        public string named;
        public void Printf()
        {
            Console.WriteLine($"{named}, {price}");
        }
        public MenuAndSubMenu(string name, int cost)
        {
            named = name;
            price = cost;
        }
        private static void RollMenu(string[] m)
        {
            foreach (string x in m)
            {
                Console.WriteLine(x);
            }
        }
        private static void ShowAmount(int amount)
        {
            Console.Write($"\n\n Всего ($): {amount}");
        }
        public static void fileSave(List<MenuAndSubMenu> lisst, int amnt, int order_num)
        {
            DateTime date = DateTime.Now;
            string o_num = "\n\n Заказ №: " + Convert.ToString(order_num);
            string dorder = "\n " + Convert.ToString(date);
            string det = "\n Торт заказан, вот все детали:\n";
            string total = "\n\n Всего ($): " + Convert.ToString(amnt) + '\n';
            string path = @"C:\Users\griba\Documents\Orders.txt";
            File.AppendAllText(path, dorder);
            File.AppendAllText(path, o_num);
            File.AppendAllText(path, total);
            File.AppendAllText(path, det);
            using (StreamWriter wptr = File.AppendText(path))
            {
                foreach (var w in lisst)
                {
                    wptr.WriteLine(string.Format("Особенность: {0}; Цена: {1}", w.named, w.price.ToString()));
                }
                wptr.Close();
            }
        }
        public static void listing()
        {
            Console.Clear();
            List<MenuAndSubMenu> als = new List<MenuAndSubMenu>();
            int amount = 0;
            int pos = 3;
            int ord_num = 0;
            const string message = "Пекарня крутая\n";
            Console.WriteLine(message + "\n");
            string[] MainMenu = { "   1. Форма ", "   2. Размер ", "   3. Вкус ", "   4. Слои ", "   5. Глазурь ", "   6. Украшения "};
            RollMenu(MainMenu);
            ShowAmount(amount);
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            ConsoleKeyInfo keyin_Main;
            while (true)
            {
                keyin_Main = Console.ReadKey();
                if (keyin_Main.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                }
                else if (keyin_Main.Key == ConsoleKey.S)
                {
                    pos++;
                }
                else if (keyin_Main.Key == ConsoleKey.P)
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine(message + "\n");
                RollMenu(MainMenu);
                ShowAmount(amount);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                if (pos == 3 && keyin_Main.Key == ConsoleKey.Enter) // listing 1-st sub-menu 
                {
                    Console.Clear();
                    Console.WriteLine("Форма торта: \n");
                    MenuAndSubMenu S1 = new MenuAndSubMenu("\tКруг", 6);
                    MenuAndSubMenu S2 = new MenuAndSubMenu("\tКуб", 7);
                    MenuAndSubMenu S3 = new MenuAndSubMenu("\tТреугольник", 8);
                    MenuAndSubMenu S4 = new MenuAndSubMenu("\tБашня", 9);
                    S1.Printf();
                    S2.Printf();
                    S3.Printf();
                    S4.Printf();
                    ShowAmount(amount);
                    int p = 2;
                    Console.SetCursorPosition(0, p);
                    Console.WriteLine("->");
                    ConsoleKeyInfo onS1;
                    do
                    {
                        onS1 = Console.ReadKey();
                        if (onS1.Key == ConsoleKey.UpArrow)
                        {
                            p--;
                        }
                        if (onS1.Key == ConsoleKey.DownArrow)
                        {
                            p++;
                        }
                        Console.Clear();
                        Console.WriteLine("Форма торта: \n");
                        S1.Printf();
                        S2.Printf();
                        S3.Printf();
                        S4.Printf();
                        ShowAmount(amount);
                        Console.SetCursorPosition(0, p);
                        Console.WriteLine("->");
                        if (p == 2 && onS1.Key == ConsoleKey.Enter)
                        {
                            als.Add(S1);
                            amount += 6;
                        }
                        if (p == 3 && onS1.Key == ConsoleKey.Enter)
                        {
                            als.Add(S2);
                            amount += 7;
                        }
                        if (p == 4 && onS1.Key == ConsoleKey.Enter)
                        {
                            als.Add(S3);
                            amount += 8;
                        }
                        if (p == 5 && onS1.Key == ConsoleKey.Enter)
                        {
                            als.Add(S4);
                            amount += 9;
                        }
                    } while (onS1.Key != ConsoleKey.Escape);
                }
                else if (pos == 4 && keyin_Main.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Размер торта: \n");
                    MenuAndSubMenu S5 = new MenuAndSubMenu("\t13x20", 4);
                    MenuAndSubMenu S6 = new MenuAndSubMenu("\t20x25", 5);
                    MenuAndSubMenu S7 = new MenuAndSubMenu("\t25x30", 7);
                    MenuAndSubMenu S8 = new MenuAndSubMenu("\t30x40", 9);
                    S5.Printf();
                    S6.Printf();
                    S7.Printf();
                    S8.Printf();
                    ShowAmount(amount);
                    int p = 2;
                    Console.SetCursorPosition(0, p);
                    Console.WriteLine("->");
                    ConsoleKeyInfo onS2;
                    do
                    {
                        onS2 = Console.ReadKey();
                        if (onS2.Key == ConsoleKey.UpArrow)
                        {
                            p--;
                        }
                        if (onS2.Key == ConsoleKey.DownArrow)
                        {
                            p++;
                        }
                        Console.Clear();
                        Console.WriteLine("Размер торта: \n");
                        S5.Printf();
                        S6.Printf();
                        S7.Printf();
                        S8.Printf();
                        ShowAmount(amount);
                        Console.SetCursorPosition(0, p);
                        Console.WriteLine("->");
                        if (p == 2 && onS2.Key == ConsoleKey.Enter)
                        {
                            als.Add(S5);
                            amount += 4;
                        }
                        if (p == 3 && onS2.Key == ConsoleKey.Enter)
                        {
                            als.Add(S6);
                            amount += 5;
                        }
                        if (p == 4 && onS2.Key == ConsoleKey.Enter)
                        {
                            als.Add(S7);
                            amount += 7;
                        }
                        if (p == 5 && onS2.Key == ConsoleKey.Enter)
                        {
                            als.Add(S8);
                            amount += 9;
                        }

                    } while (onS2.Key != ConsoleKey.Escape);

                }
                else if (pos == 5 && keyin_Main.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Вкус торта: \n");
                    MenuAndSubMenu S9 = new MenuAndSubMenu("\tПетухон", 1);
                    MenuAndSubMenu S10 = new MenuAndSubMenu("\tСишарп", 2);
                    MenuAndSubMenu S11 = new MenuAndSubMenu("\tПлюсы", 4);
                    MenuAndSubMenu S12 = new MenuAndSubMenu("\tжава", 6);
                    S9.Printf();
                    S10.Printf();
                    S11.Printf();
                    S12.Printf();
                    ShowAmount(amount);
                    int p = 2;
                    Console.SetCursorPosition(0, p);
                    Console.WriteLine("->");
                    ConsoleKeyInfo onS3;
                    do
                    {
                        onS3 = Console.ReadKey();
                        if (onS3.Key == ConsoleKey.UpArrow)
                        {
                            p--;
                        }
                        if (onS3.Key == ConsoleKey.DownArrow)
                        {
                            p++;
                        }
                        Console.Clear();
                        Console.WriteLine("Вкус торта: \n");
                        S9.Printf();
                        S10.Printf();
                        S11.Printf();
                        S12.Printf();
                        ShowAmount(amount);
                        Console.SetCursorPosition(0, p);
                        Console.WriteLine("->");
                        if (p == 2 && onS3.Key == ConsoleKey.Enter)
                        {
                            als.Add(S9);
                            amount += 1;
                        }
                        if (p == 3 && onS3.Key == ConsoleKey.Enter)
                        {
                            als.Add(S10);
                            amount += 2;
                        }
                        if (p == 4 && onS3.Key == ConsoleKey.Enter)
                        {
                            als.Add(S11);
                            amount += 4;
                        }
                        if (p == 5 && onS3.Key == ConsoleKey.Enter)
                        {
                            als.Add(S12);
                            amount += 6;
                        }

                    } while (onS3.Key != ConsoleKey.Escape);
                }
                else if (pos == 6 && keyin_Main.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Сколько слоёв?: \n");
                    MenuAndSubMenu S13 = new MenuAndSubMenu("\t3 слоя", 6);
                    MenuAndSubMenu S14 = new MenuAndSubMenu("\t4 слоя", 7);
                    MenuAndSubMenu S15 = new MenuAndSubMenu("\t5 слоёв", 12);
                    MenuAndSubMenu S16 = new MenuAndSubMenu("\t6 слоёв", 20);
                    S13.Printf();
                    S14.Printf();
                    S15.Printf();
                    S16.Printf();
                    ShowAmount(amount);
                    int p = 2;
                    Console.SetCursorPosition(0, p);
                    Console.WriteLine("->");
                    ConsoleKeyInfo onS4;
                    do
                    {
                        onS4 = Console.ReadKey();
                        if (onS4.Key == ConsoleKey.UpArrow)
                        {
                            p--;
                        }
                        if (onS4.Key == ConsoleKey.DownArrow)
                        {
                            p++;
                        }
                        Console.Clear();
                        Console.WriteLine("Сколько слоёв?: \n");
                        S13.Printf();
                        S14.Printf();
                        S15.Printf();
                        S16.Printf();
                        ShowAmount(amount);
                        Console.SetCursorPosition(0, p);
                        Console.WriteLine("->");
                        if (p == 2 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S13);
                            amount += 6;
                        }
                        if (p == 3 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S14);
                            amount += 7;
                        }
                        if (p == 4 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S15);
                            amount += 12;
                        }
                        if (p == 5 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S16);
                            amount += 20;
                        }

                    } while (onS4.Key != ConsoleKey.Escape);
                }
                else if (pos == 7 && keyin_Main.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите глазурь: \n");
                    MenuAndSubMenu S17 = new MenuAndSubMenu("\tБелочоколадная глазурь", 3);
                    MenuAndSubMenu S18 = new MenuAndSubMenu("\tМолочночоколадная глазурь", 3);
                    MenuAndSubMenu S19 = new MenuAndSubMenu("\tЦветная глазурь", 4);
                    MenuAndSubMenu S20 = new MenuAndSubMenu("\tФиолетовая глазурь", 6);
                    MenuAndSubMenu S21 = new MenuAndSubMenu("\tВкусная глазурь", 7);
                    MenuAndSubMenu S22 = new MenuAndSubMenu("\tДорогая глазурь", 9);
                    S17.Printf();
                    S18.Printf();
                    S19.Printf();
                    S20.Printf();
                    S21.Printf();
                    S22.Printf();
                    ShowAmount(amount);
                    int p = 2;
                    Console.SetCursorPosition(0, p);
                    Console.WriteLine("->");
                    ConsoleKeyInfo onS4;
                    do
                    {
                        onS4 = Console.ReadKey();
                        if (onS4.Key == ConsoleKey.UpArrow)
                        {
                            p--;
                        }
                        if (onS4.Key == ConsoleKey.DownArrow)
                        {
                            p++;
                        }
                        Console.Clear();
                        Console.WriteLine("Выберите глазурь: \n");
                        S17.Printf();
                        S18.Printf();
                        S19.Printf();
                        S20.Printf();
                        S21.Printf();
                        S22.Printf();
                        ShowAmount(amount);
                        Console.SetCursorPosition(0, p);
                        Console.WriteLine("->");
                        if (p == 2 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S17);
                            amount += 3;
                        }
                        if (p == 3 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S18);
                            amount += 3;
                        }
                        if (p == 4 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S19);
                            amount += 4;
                        }
                        if (p == 5 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S20);
                            amount += 6;
                        }
                        if (p == 6 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S21);
                            amount += 7;
                        }
                        if (p == 7 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S22);
                            amount += 9;
                        }
                    } while (onS4.Key != ConsoleKey.Escape);
                }
                else if (pos == 8 && keyin_Main.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Украшение для торта: \n");
                    MenuAndSubMenu S23 = new MenuAndSubMenu("\tЖаренные гвозди", 3);
                    MenuAndSubMenu S24 = new MenuAndSubMenu("\tШурупы", 5);
                    MenuAndSubMenu S25 = new MenuAndSubMenu("\tАрешки", 10);
                    MenuAndSubMenu S26 = new MenuAndSubMenu("\tРозы", 11);
                    MenuAndSubMenu S27 = new MenuAndSubMenu("\tКуски бетона", 12);
                    MenuAndSubMenu S28 = new MenuAndSubMenu("\tМашина", 14);
                    S23.Printf();
                    S24.Printf();
                    S25.Printf();
                    S26.Printf();
                    S27.Printf();
                    S28.Printf();
                    ShowAmount(amount);
                    int p = 2;
                    Console.SetCursorPosition(0, p);
                    Console.WriteLine("->");
                    ConsoleKeyInfo onS4;
                    do
                    {
                        onS4 = Console.ReadKey();
                        if (onS4.Key == ConsoleKey.UpArrow)
                        {
                            p--;
                        }
                        if (onS4.Key == ConsoleKey.DownArrow)
                        {
                            p++;
                        }
                        Console.Clear();
                        Console.WriteLine("Украшение для торта: \n");
                        S23.Printf();
                        S24.Printf();
                        S25.Printf();
                        S26.Printf();
                        S27.Printf();
                        S28.Printf();
                        ShowAmount(amount);
                        Console.SetCursorPosition(0, p);
                        Console.WriteLine("->");
                        if (p == 2 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S23);
                            amount += 3;
                        }
                        if (p == 3 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S24);
                            amount += 5;
                        }
                        if (p == 4 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S25);
                            amount += 10;
                        }
                        if (p == 5 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S26);
                            amount += 11;
                        }
                        if (p == 6 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S27);
                            amount += 12;
                        }
                        if (p == 7 && onS4.Key == ConsoleKey.Enter)
                        {
                            als.Add(S28);
                            amount += 14;
                        }
                    } while (onS4.Key != ConsoleKey.Escape);
                }
                else if (pos == 9 && keyin_Main.Key == ConsoleKey.Enter)
                {
                    ord_num++;
                    fileSave(als, amount, ord_num);
                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ! Торт прибудет к вам через 2 дня!:)\n");
                }
            }
        }
    }
    class Main_p
    {
        static void Main()
        {
            MenuAndSubMenu.listing();
        }
    }
}