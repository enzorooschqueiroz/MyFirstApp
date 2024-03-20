// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args) 
    {
        string name = "";

        Console.Write("What is your name ? : ");
        name = Console.ReadLine();
        Console.WriteLine("Nice to meet you " + name);
        
    }
}