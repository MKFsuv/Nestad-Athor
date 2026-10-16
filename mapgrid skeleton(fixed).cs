using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;

string[,] map =
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
    Console.WriteLine("Use W,S,A,D to move.");
    Console.WriteLine("Current Board:");
    for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(map[i, j] + " ");
        }
        Console.WriteLine();
    }

    ConsoleKey input = Console.ReadKey(true).Key;
    switch (input)
    {
        case ConsoleKey.W:
            MoveUp(map);
            break;
        case ConsoleKey.S:
            MoveDown(map);
            break;
        case ConsoleKey.A:
            MoveLeft(map);
            break;
        case ConsoleKey.D:
            MoveRight(map);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Invalid input.");
            break;
    }
}

static void MoveUp(string[,] b)
{
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            if (b[i, j] == "O")
            {
                if (b[i - 1, j] == " ")
                {
                    Console.Clear();
                    b[i, j] = " ";
                    b[i - 1, j] = "O";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You hit a wall!");
                }

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
            if (b[i, j] == "O")
            {
                if (b[i + 1, j] == " ")
                {
                    Console.Clear();
                    b[i, j] = " ";
                    b[i + 1, j] = "O";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You hit a wall!");
                }

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
            if (b[i, j] == "O")
            {
                if (b[i, j - 1] == " ")
                {
                    Console.Clear();
                    b[i, j] = " ";
                    b[i, j - 1] = "O";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You hit a wall!");
                }

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
            if (b[i, j] == "O")
            {
                if (b[i, j + 1] == " ")
                {
                    Console.Clear();
                    b[i, j] = " ";
                    b[i, j + 1] = "O";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You hit a wall!");
                }

                return;
            }
        }
    }
}
