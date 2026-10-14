using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
Console.WriteLine("Use W,S,A,D to move.");

string[,] board =
{
  {"┌", "─", "─", "─", "─", "─", "─", "─", "─", "┐" },
  {"│", "O", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"└", "─", "─", "─", "─", "─", "─", "─", "─", "┘" }
};

while (true)
{
    Console.Clear();
    Console.WriteLine("Use W,S,A,D to move.");
    Console.WriteLine("Current Board:");
    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();
    }

    ConsoleKey input = Console.ReadKey(true).Key;
    switch (input)
    {
        case ConsoleKey.W:
            MoveUp(board);
            break;
        case ConsoleKey.S:
            MoveDown(board);
            break;
        case ConsoleKey.A:
            MoveLeft(board);
            break;
        case ConsoleKey.D:
            MoveRight(board);
            break;
        default:
            break;
    }
}

static void MoveUp(string[,] b)
{
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            if (b[i, j] == "O" && i > 0)
            {
                b[i, j] = " ";
                b[i - 1, j] = "O";
                return;
            }
            else if (b[i, j] == "O" && i > 0)
            {
                b[i, j] = "─";
                b[i, j] = "O";
                Console.WriteLine("You hit a wall!");
                return;
            }
        }
    }
}

static void MoveDown(string[,] b)
{
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            if (b[i, j] == "O" && i < b.GetLength(0) - 1)
            {
                b[i, j] = " ";
                b[i + 1, j] = "O";
                return;
            }
            else if (b[i, j] == "O" && i < b.GetLength(0) - 1)
            {
                b[i, j] = "─";
                b[i, j] = "O";
                Console.WriteLine("You hit a wall!");
                return;
            }
        }
    }
}

static void MoveLeft(string[,] b)
{
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            if (b[i, j] == "O" && j > 0)
            {
                b[i, j] = " ";
                b[i, j - 1] = "O";
                return;
            }
            else if (b[i, j] == "O" && j > 0)
            {
                b[i, j] = "│";
                b[i, j] = "O";
                Console.WriteLine("You hit a wall!");
                return;
            }
        }
    }
}

static void MoveRight(string[,] b)
{
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            if (b[i, j] == "O" && j < b.GetLength(1) - 1)
            {
                b[i, j] = " ";
                b[i, j + 1] = "O";
                return;
            }
            else if (b[i, j] == "O" && j < b.GetLength(1) - 1)
            {
                b[i, j] = "│";
                b[i, j] = "O";
                Console.WriteLine("You hit a wall!");
                return;
            }
        }
    }
}
                        }
                        break;
                    }
                }
            }
            break;
        case ConsoleKey.D:
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "Õ")
                    {
                        if (j < map.GetLength(1) - 2 && map[i, j + 1] == " ")
                        {
                            map[i, j] = " ";
                            map[i, j + 1] = "Õ";
                        }
                        break;
                    }
                }
            }
            break;
    }
}
