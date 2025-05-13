using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_sus_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentince:");
            string[] sentince = Console.ReadLine().Split(' ');

            Console.WriteLine($"The words in the sentince are: {sentince.Count()}");
            Console.WriteLine("---------------------------------------");

            string lastWord = sentince[sentince.Length - 1];
            string reversed = "";
            for (int i = 1; i <= lastWord.Length; i++) 
            {
                char letter = lastWord[lastWord.Length - i];
                reversed += letter;
            }
            Console.WriteLine($"The last word in the sentice reversed is: {reversed} ");
            Console.WriteLine("---------------------------------------");

            Console.Write("Enter a search word: ");
            string search = Console.ReadLine();
            byte count = 0;

            for (int i = 0; i < sentince.Length; i++)
            {
                if (sentince[i] == search)
                {
                    count++;
                    sentince[i].Replace(search, "###");
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"Broi na namereni -> {count}");
            }
            else
            {
                Console.WriteLine("НЯМА СЪВПАДЕНИЕ!!!");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"broi na napraweni zameni -> {count}");
            Console.WriteLine("---------------------------------------");


            string longest = "";
            for (int i = 0; i < sentince.Length; i++)
            {
                if (sentince[i].Length > longest.Length)
                {
                    longest = sentince[i];
                }
            }
            Console.WriteLine($"The longest word is {longest} with length -> {longest.Length}");
            Console.WriteLine("---------------------------------------");




            int palCount = 0;
            for (int i = 0; i < sentince.Length; i++)
            {
                string word = sentince[i];
                string palindrom = "";
                for (int k = sentince.Length - 1; 0 <= i; i--)
                {
                    palindrom = palindrom + word[k];
                    if (palindrom == word)
                    {
                       palCount++;
                        Console.WriteLine(palindrom);
                    }
                }
                if ( palCount == 0 )
                {
                    Console.WriteLine("НЯМА ПАЛИНДРОМИ");
                }
            }
        }
    }
}
