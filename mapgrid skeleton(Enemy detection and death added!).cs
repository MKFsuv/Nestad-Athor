using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;

string[,] map =
{
  {"┌", "─", "─", "─", "─", "─", "─", "─", "─", "┐" },
  {"│", "O", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", "E", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"│", " ", " ", " ", " ", " ", " ", " ", " ", "│" },
  {"└", "─", "─", "─", "─", "─", "─", "─", "─", "┘" }
};
bool alive = true;
do
{
    Console.WriteLine("Use W,S,A,D to move and Arrow Keys to attack!");
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
        case ConsoleKey.UpArrow:
            AttackUp(map);
            break;
        case ConsoleKey.DownArrow:
            AttackDown(map);
            break;
        case ConsoleKey.LeftArrow:
            AttackLeft(map);
            break;
        case ConsoleKey.RightArrow:
            AttackRight(map);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Invalid input.");
            break;
    }


    void MoveUp(string[,] b)
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
                    else if (b[i - 1, j] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You Touched the enemy! \n GAME OVER.");
                        alive = false;
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

    void MoveDown(string[,] b)
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
                    else if (b[i + 1, j] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You Touched the enemy! \n GAME OVER.");
                        alive = false;
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

    void MoveLeft(string[,] b)
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
                    else if (b[i, j - 1] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You Touched the enemy! \n GAME OVER.");
                        alive = false;
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

    void MoveRight(string[,] b)
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
                    else if (b[i, j + 1] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You Touched the enemy! \n GAME OVER.");
                        alive = false;
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

    static void AttackUp(string[,] b)
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
                        Console.WriteLine("You attacked up!");
                        b[i - 1, j] = "/";
                        Thread.Sleep(500);
                        b[i - 1, j] = " ";
                    }
                    else if (b[i - 1, j] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked up and hit the enemy!");
                        b[i - 1, j] = "X";
                        Thread.Sleep(500);
                        b[i - 1, j] = " ";
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked up but hit a wall!");
                    }

                }
            }
        }
    }

    static void AttackDown(string[,] b)
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
                        Console.WriteLine("You attacked down!");
                        b[i + 1, j] = "/";
                        Thread.Sleep(500);
                        b[i + 1, j] = " ";
                    }
                    else if (b[i + 1, j] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked down and hit the enemy!");
                        b[i + 1, j] = "X";
                        Thread.Sleep(500);
                        b[i + 1, j] = " ";
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked down but hit a wall!");
                    }

                }
            }
        }
    }

    static void AttackLeft(string[,] b)
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
                        Console.WriteLine("You attacked left!");
                        b[i, j - 1] = "/";
                        Thread.Sleep(500);
                        b[i, j - 1] = " ";
                    }
                    else if (b[i, j - 1] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked left and hit the enemy!");
                        b[i, j - 1] = "X";
                        Thread.Sleep(500);
                        b[i, j - 1] = " ";
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked left but hit a wall!");
                    }

                }
            }
        }
    }

    static void AttackRight(string[,] b)
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
                        Console.WriteLine("You attacked right!");
                        b[i, j + 1] = "/";
                        Thread.Sleep(500);
                        b[i, j + 1] = " ";

                    }
                    else if (b[i, j + 1] == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked right and hit the enemy!");
                        b[i, j + 1] = "X";
                        Thread.Sleep(500);
                        b[i, j + 1] = " ";
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You attacked right but hit a wall!");
                    }

                }
            }
        }
    }
}
while (alive == true);
