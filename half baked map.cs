// Character is Õ
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
Console.WriteLine("Use W,S,A,D to move.");

string[,] map = 
{
  {"┌", "─", "─", "─", "─", "─", "─", "─", "─", "┐" },
  {"│", "Õ", " ", " ", " ", " ", " ", " ", " ", "│" },
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
    Console.WriteLine("Current Board:");
    string movement switch (movement)
    {
        for (int i = 0; i < map.GetLength(0); i++)
    {
        for (int j = 0; j < map.GetLength(1); j++)
        {
            Console.Write(map[i, j] + " ");
        }
        Console.WriteLine();
    }
    ConsoleKey input = Console.ReadKey().Key;
    switch (input)
    {
        case ConsoleKey.W:
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "Õ")
                    {
                        if (i > 1 && map[i - 1, j] == " ")
                        {
                            map[i, j] = " ";
                            map[i - 1, j] = "Õ";
                        }
                        break;
                    }
                }
            }
            break;
        case ConsoleKey.S:
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "Õ")
                    {
                        if (i < map.GetLength(0) - 2 && map[i + 1, j] == " ")
                        {
                            map[i, j] = " ";
                            map[i + 1, j] = "Õ";
                        }
                        break;
                    }
                }
            }
            break;
        case ConsoleKey.A:
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "Õ")
                    {
                        if (j > 1 && map[i, j - 1] == " ")
                        {
                            map[i, j] = " ";
                            map[i, j - 1] = "Õ";
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