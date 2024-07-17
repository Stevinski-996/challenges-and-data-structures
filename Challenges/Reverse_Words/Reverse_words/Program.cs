using System;
using System.Collections;

namespace Reverse_Words
{
public class Program {
    public static void Main (string[] args) 
    {
        Console.WriteLine("Enter your text here :");
        string str = Console.ReadLine();
        string output = ReversWord(str);
        Console.WriteLine(output);

    }
public static string ReversWord(string word){
    string[] words = word.Split(' ');
    string[] rw = new string[words.Length];
    for(int i = 0; i < words.Length ; i++) {
        rw[i] = words[words.Length-(i+1)];
    }
    return string.Join(" ", rw);    ;
}

    }
}