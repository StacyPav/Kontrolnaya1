using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] Strings = new string[] { "Hello", "2", "world", ":-)" };
        string[] Strings_2 = new string[4]; //
        
        for (int i = 0; i < Strings.Length; i++)
        {
            int y = 0, t = 1;
            if (i % 3 == 0)
                Strings_2[y] = Strings[i];
            Console.Write(" " +Strings[i]);
        }
        Console.Write("\n");
        
        for (int j = 0; j < Strings_2.Length; j++)
            Console.Write(" " +Strings_2[j]);
    }
}
