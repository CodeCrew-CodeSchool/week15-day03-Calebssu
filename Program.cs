namespace week15_day03_Calebssu;

class Program
{
    public static bool runtime = true;
    static void Main(string[] args)
    { 
        while (runtime == true){
            GameBoard.board();
            Player.placeTickX();
            Game.Check();
            if(runtime == false){
                break;
            }
            Player.placeTickO();
            Game.Check();
            if(runtime == false){
                break;
            }
        }
    }
}

class GameBoard {
    public static string one = "1";
    public static string two = "2";
    public static string three = "3";
    public static string four = "4";
    public static string five = "5";
    public static string six = "6";
    public static string seven = "7";
    public static string eight = "8";
    public static string nine = "9";

    public static void board(){
        Console.WriteLine($"|{one}||{two}||{three}|");
        Console.WriteLine($"|{four}||{five}||{six}|");
        Console.WriteLine($"|{seven}||{eight}||{nine}|");
    }
}

class Player {
    public static string playerOne = "Player X";
    public static string playerTwo = "Player O";

    public static void placeTickX(){
        Console.WriteLine($"Your turn {playerOne}");
        int input = Convert.ToInt32(Console.ReadLine());
        switch(input){
            case 1:
            GameBoard.one = "X";
            break;
            case 2:
            GameBoard.two = "X";
            break;
            case 3:
            GameBoard.three = "X";
            break;
            case 4:
            GameBoard.four = "X";
            break;
            case 5:
            GameBoard.five = "X";
            break;
            case 6:
            GameBoard.six = "X";
            break;
            case 7:
            GameBoard.seven = "X";
            break;
            case 8:
            GameBoard.eight = "X";
            break;
            case 9:
            GameBoard.nine = "X";
            break;
            default:
            Program.runtime = false;
            Console.WriteLine("Invalid input, ending game.");
            break;
        }
    }
    public static void placeTickO(){
        Console.WriteLine($"Your turn {playerTwo}");
        int input = Convert.ToInt32(Console.ReadLine());
        switch(input){
            case 1:
            GameBoard.one = "O";
            break;
            case 2:
            GameBoard.two = "O";
            break;
            case 3:
            GameBoard.three = "O";
            break;
            case 4:
            GameBoard.four = "O";
            break;
            case 5:
            GameBoard.five = "O";
            break;
            case 6:
            GameBoard.six = "O";
            break;
            case 7:
            GameBoard.seven = "O";
            break;
            case 8:
            GameBoard.eight = "O";
            break;
            case 9:
            GameBoard.nine = "O";
            break;
            default:
            Program.runtime = false;
            Console.WriteLine("Invalid input, ending game.");
            break;
        }
    }
}

class Game {
    public static void Check(){
        if(GameBoard.one == "X" && GameBoard.two == "X" && GameBoard.three == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.one == "X" && GameBoard.five == "X" && GameBoard.nine == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.seven == "X" && GameBoard.five == "X" && GameBoard.three == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.one == "X" && GameBoard.four == "X" && GameBoard.seven == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.two == "X" && GameBoard.five == "X" && GameBoard.eight == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.three == "X" && GameBoard.six == "X" && GameBoard.nine == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.four == "X" && GameBoard.five == "X" && GameBoard.six == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.seven == "X" && GameBoard.eight == "X" && GameBoard.nine == "X"){
            Console.WriteLine("X wins!");
            GameBoard.board();
            Program.runtime = false;
        }

        if(GameBoard.one == "O" && GameBoard.two == "O" && GameBoard.three == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.one == "O" && GameBoard.five == "O" && GameBoard.nine == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.seven == "O" && GameBoard.five == "O" && GameBoard.three == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.one == "O" && GameBoard.four == "O" && GameBoard.seven == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.two == "O" && GameBoard.five == "O" && GameBoard.eight == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.three == "O" && GameBoard.six == "O" && GameBoard.nine == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.four == "O" && GameBoard.five == "O" && GameBoard.six == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        } else if(GameBoard.seven == "O" && GameBoard.eight == "O" && GameBoard.nine == "O"){
            Console.WriteLine("O wins!");
            GameBoard.board();
            Program.runtime = false;
        }

        if(Program.runtime == true){
            if(GameBoard.one != "1" && GameBoard.two != "2" && GameBoard.three != "3" && GameBoard.four != "4" && GameBoard.five != "5" && GameBoard.six != "6" && GameBoard.seven != "7" && GameBoard.eight != "8" && GameBoard.nine != "9"){
                Console.WriteLine("Draw.");
                GameBoard.board();
                Program.runtime = false;
            }
        }
    }
}
