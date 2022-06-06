using System;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Player player1 = new Player("Вы");
                Player player2 = new Player("Робот");
                Game game = new Game(player1, player2);

                while (true)
                {
                    StartGame(game);
                    Console.WriteLine("Для продолжения игры нажмите Enter ");
                    Console.WriteLine("Для выхода введите *");
                    if (Console.ReadLine() == "*")
                    {
                        return;
                    }
                }
            }
            catch { };
        }


        static void StartGame(Game game)
        {
            Console.WriteLine(game.SravneniePayers());
        }
    }
    //Свойства Игроков
    public class Player
    {
        //Имя
        public string Name { get; }
        //Карты Пользователя
        public int VarPlayer1 { get; set; }
        //Карты Робота
        public int VarPlayer2 { get; set; }

        public Player(string name)
        {

            Name = name;

        }

    }
}
