using System;
using System.Collections.Generic; //using para listas

namespace Exercíci_Orientacao_Objeto_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Amanda");
            list.Add("Luisa");
            list.Add("Camila");
            list.Add("Ana");
            list.Add("Wagner");
            list.Add("Fabiana");
            list.Add("Sabrina");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------");

            //TAMANHO DA LISTA
            Console.WriteLine("List Count: " + list.Count);

            //ENCONTRAR O PRIMEIRO DA LISTA
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            //ENCONTRAR O ULTIMO DA LISTA
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //ENCONTRAR A PRIMEIRA POSIÇÃO DA LISTA
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);

            //ENCONTRAR A ULTIMA POSIÇÃO DA LISTA
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + pos2);

            //FILTRAR A LISTA: NOMES COM APENAS 5 CARACTERES
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //REMOVER ELEMENTOS DA LISTA
            list.Remove("Camila");
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
                        

            list.RemoveAll(x => x[0] == 'L');
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(6, 2);
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }

    }
}
