using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Game
    {
        //Колода пользователя
        public Player Player1 { get; }

        //Колода робота
        public Player Player2 { get; }

        //Массив из которого будет производиться выборка чисел привязанных к опр картам
        public int[] carts = new int[]
        {
            1, 3, 7, 15, 31, 63, 127 ,255 ,511, 1023, 2047, 4095, 8191
        };

        //Рандомайзер на выдачу карт Пользователю
        public int Coloda1()
        {
            Random random = new Random();

            return carts[random.Next(0, carts.Length)];
        }

        //Рандомайзер на выдачу карт Роботу
        public int Coloda2()
        {
            Random random = new Random();

            return carts[random.Next(0, carts.Length)];

        }
        public Game(Player gamer1, Player gamer2)
        {
            try
            {
                Player1 = gamer1 ?? throw new ArgumentNullException("Ошибка");
                Player2 = gamer2 ?? throw new ArgumentNullException("Ошибка");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // ход игроков
        public string SravneniePayers()
        {
            for (int q = 0; q < 1; q++)
            {
                Console.WriteLine("Раздаём карты");
                //Блокировка потока
                System.Threading.Thread.Sleep(500);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Игроки меняются картами...");
                //Блокировка потока
                System.Threading.Thread.Sleep(500);
            }
            //Костыли
            #region
            //Очки  Пользователя
            Player1.VarPlayer1 = Coloda1();
            switch (Player1.VarPlayer1)// выводим то, что собрал Пользователь
            {
                case 1:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 2");
                    break;
                case 3:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 3");
                    break;
                case 7:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 4");
                    break;
                case 15:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 5");
                    break;
                case 31:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 6");
                    break;
                case 63:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 7");
                    break;
                case 127:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 8");
                    break;
                case 255:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 9");
                    break;
                case 511:
                    Console.WriteLine("Первый игрок собрал 4 карты со старшинством 10");
                    break;
                case 1023:
                    Console.WriteLine("Первый игрок собрал 4 В");
                    break;
                case 2047:
                    Console.WriteLine("Первый игрок собрал 4 Д");
                    break;
                case 4095:
                    Console.WriteLine("Первый игрок собрал 4 К");
                    break;
                case 8191:
                    Console.WriteLine("Первый игрок собрал 4 Т");
                    break;
            }
            //Очки Робота
            Player2.VarPlayer2 = Coloda2();
            switch (Player2.VarPlayer2)// выводим то, что собрал Робот
            {
                case 1:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 2");
                    break;
                case 3:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 3");
                    break;
                case 7:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 4");
                    break;
                case 15:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 5");
                    break;
                case 31:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 6");
                    break;
                case 63:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 7");
                    break;
                case 127:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 8");
                    break;
                case 255:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 9");
                    break;
                case 511:
                    Console.WriteLine("Робот собрал 4 карты со старшинством 10");
                    break;
                case 1023:
                    Console.WriteLine("Робот собрал 4 В");
                    break;
                case 2047:
                    Console.WriteLine("Робот собрал 4 Д");
                    break;
                case 4095:
                    Console.WriteLine("Робот собрал 4 К");
                    break;
                case 8191:
                    Console.WriteLine("Робот собрал 4 Т");
                    break;
            }
            #endregion

            //Результаты
            string rez = GameIf(Player1, Player2);
            Itog itog = new Itog();
            return itog.chek(Player1.VarPlayer1, Player2.VarPlayer2);
        }
        static string GameIf(Player player1, Player player2)
        {
            return string.Empty;
        }
    }
}
