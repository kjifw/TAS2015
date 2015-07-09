namespace _04.Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public static void Main(string[] arguments)
        {
            const int BoxesWithoutMines = 35;

            string command = string.Empty;

            char[,] gameField = GenerateGameField();
            char[,] mineField = PlaceMines();

            int counter = 0;
            bool isMineHit = false;

            List<Player> listOfPlayers = new List<Player>(6);

            int row = 0;
            int col = 0;

            bool isGameStart = true;
            bool isGameWon = false;

            do
            {
                if (isGameStart)
                {
                    Console.WriteLine("Lets play “Mines”. Try to find all boxes without hitting a mine." +
                    " Command 'top' shows standings, 'restart' restarts the game, 'exit' exits the game");

                    PrintGameField(gameField);
                    isGameStart = false;
                }

                Console.Write("Input row and col: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) &&
                        col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GenerateStandings(listOfPlayers);
                        break;
                    case "restart":
                        gameField = GenerateGameField();
                        mineField = PlaceMines();
                        PrintGameField(gameField);

                        isMineHit = false;
                        isGameStart = false;

                        break;
                    case "exit":
                        Console.WriteLine("Bye Bye Bye!");
                        break;
                    case "turn":
                        if (mineField[row, col] != '*')
                        {
                            if (mineField[row, col] == '-')
                            {
                                ShowBoxValue(gameField, mineField, row, col);
                                counter++;
                            }

                            if (BoxesWithoutMines == counter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                PrintGameField(gameField);
                            }
                        }
                        else
                        {
                            isMineHit = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (isMineHit)
                {
                    PrintGameField(mineField);
                    Console.Write("\nGame Over! You died with {0} points. Input name: ", counter);

                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, counter);

                    if (listOfPlayers.Count < 5)
                    {
                        listOfPlayers.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < listOfPlayers.Count; i++)
                        {
                            if (listOfPlayers[i].Points < currentPlayer.Points)
                            {
                                listOfPlayers.Insert(i, currentPlayer);
                                listOfPlayers.RemoveAt(listOfPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    listOfPlayers.Sort((Player x, Player y) => y.Name.CompareTo(x.Name));
                    listOfPlayers.Sort((Player x, Player y) => y.Points.CompareTo(x.Points));
                    GenerateStandings(listOfPlayers);

                    gameField = GenerateGameField();
                    mineField = PlaceMines();
                    counter = 0;
                    isMineHit = false;
                    isGameStart = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nCongradulation! You opened 35 boxes without hitting a mine.");

                    PrintGameField(mineField);

                    Console.WriteLine("Input name: ");
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, counter);

                    listOfPlayers.Add(currentPlayer);
                    GenerateStandings(listOfPlayers);

                    gameField = GenerateGameField();
                    mineField = PlaceMines();
                    counter = 0;
                    isGameWon = false;
                    isGameStart = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }

        private static void GenerateStandings(List<Player> players)
        {
            Console.WriteLine("\nPoints:");

            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} boxes",
                        i + 1,
                        players[i].Name,
                        players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Standings!\n");
            }
        }

        private static void ShowBoxValue(char[,] gameField, char[,] bombs, int row, int col)
        {
            char bombsCount = NumberSurroundingOfMines(bombs, row, col);
            bombs[row, col] = bombsCount;
            gameField[row, col] = bombsCount;
        }

        private static void PrintGameField(char[,] gameField)
        {
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", gameField[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateGameField()
        {
            int gameFieldRows = 5;
            int gameFieldColumns = 10;
            char[,] gameField = new char[gameFieldRows, gameFieldColumns];

            for (int i = 0; i < gameFieldRows; i++)
            {
                for (int j = 0; j < gameFieldColumns; j++)
                {
                    gameField[i, j] = '?';
                }
            }

            return gameField;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameFiled = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    gameFiled[row, col] = '-';
                }
            }

            List<int> mines = new List<int>();

            while (mines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!mines.Contains(randomNumber))
                {
                    mines.Add(randomNumber);
                }
            }

            foreach (int mine in mines)
            {
                int row = mine % cols;
                int col = mine / cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameFiled[col, row - 1] = '*';
            }

            return gameFiled;
        }

        private static void CalculateGameFieldValues(char[,] gameField)
        {
            int rows = gameField.GetLength(1);
            int cols = gameField.GetLength(0);

            for (int row = 0; row < cols; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (gameField[row, col] != '*')
                    {
                        char minesCount = NumberSurroundingOfMines(gameField, row, col);
                        gameField[row, col] = minesCount;
                    }
                }
            }
        }

        private static char NumberSurroundingOfMines(char[,] gameField, int row, int col)
        {
            int count = 0;
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameField[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}