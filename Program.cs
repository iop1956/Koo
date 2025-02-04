
namespace Project
{
    // 스파르타 마을에 오신 여러분 환영합니다.
    //이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.

    //1. 상태 보기
    //2. 인벤토리
    //3. 상점

    //원하시는 행동을 입력해주세요.


    internal class Program
    {
        
        class Game
        {
            private Character player;

            public Game()
            {
                player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

            }

            public void Start()
            {
                while (true)
                {
                    Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                    Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.\n");
                    Console.WriteLine("1. 상태 보기");
                    Console.WriteLine("2. 인벤토리");
                    Console.WriteLine("3. 상점");
                    Console.Write("\n원하는 행동을 입력하세요: ");

                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            ShowStatus();
                            break;
                        case "2":
                            Console.WriteLine("인벤토리 준비중입니다.");
                            break;
                        case "3":
                            Console.WriteLine("상점은 준비중입니다.");
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            Console.ReadKey();
                            break;
                    }
                }
            }

            private void ShowStatus()
            {
                Console.Clear();
                player.Status();
                Console.Write("\n0. 나가기\n원하는 행동을 입력하세요: ");
                while (Console.ReadLine() != "0")
                {
                    Console.Write("잘못된 입력입니다. 다시 입력하세요: ");
                }
            }
        }

        class Character
        {
            public string Name { get; private set; }
            public string Job { get; private set; }
            public int Level { get; private set; }
            public int Attack { get; private set; }
            public int Defense { get; private set; }
            public int Health { get; private set; }
            public int Gold { get; private set; }

            public Character(string name, string job, int level, int attack, int defense, int health, int gold)
            {
                Name = name;
                Job = job;
                Level = level;
                Attack = attack;
                Defense = defense;
                Health = health;
                Gold = gold;
            }

            public void Status()
            {
                Console.WriteLine("상태 보기\n");
                Console.WriteLine($"Lv. {Level:D2}");
                Console.WriteLine($"{Name} ({Job})");
                Console.WriteLine($"공격력 : {Attack}");
                Console.WriteLine($"방어력 : {Defense}");
                Console.WriteLine($"체 력 : {Health}");
                Console.WriteLine($"Gold  : {Gold} G");
            }

            public bool SpendGold(int amount)
            {
                if (Gold >= amount)
                {
                    Gold -= amount;
                    return true;
                }
                return false;
            }
        }
    }
}