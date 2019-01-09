﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListExample();
            //ArrayListExampleClass();
            //GenericListOfNeighborSearch();
            DictionaryOfNeighborSearch();

            Console.ReadLine();
        }

        static void ArrayListExampleClass()
        {
            var list = new ArrayList();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Next raw please");
                list.Add(Console.ReadLine());
            }

            list.Sort();
            //list.Remove();
            list.RemoveAt(list.Count-1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }


        public static void ArrayListExample()
        {
            var poem = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                var song = new Song();
                song.Lyrics = Console.ReadLine();
                poem.Add(song);
            }

            //poem.Sort();
            poem.RemoveAt(poem.Count - 1);

            object[] myArray = poem.ToArray();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

        }

        public class Song
        {
            public string Lyrics;

            public override string ToString()
            {
                return this.Lyrics;
            }
        }
        //public class Song : IComparable
        //{
        //    public string Lyrics { get; set; };

        //    public int CompareTo(object obj)
        //    {
        //        var song = obj as Song;
        //        if (Song.Lyrics == this.Lyrics)
        //        {
        //            return this.Lyrics;
        //        }
        //        else
        //        {

        //        }
        //    }

        //}

        public class Neighbor1
        {
            public string FullName { get; }

            public int FlatNumber { get; }

            public string PhoneNumber { get; }

            public Neighbor1(string fullName, int flatNumber, string phoneNumber)
            {
                this.FullName = fullName;
                this.FlatNumber = flatNumber;
                this.PhoneNumber = phoneNumber;
            }
        }

        public static void GenericListOfNeighborSearch()
        {
            List<Neighbor1> floorNeighbors = new List<Neighbor1>();
            floorNeighbors.Add(new Neighbor1("Pupkiny", 78, "911-09-99"));
            floorNeighbors.Add(new Neighbor1("Browns", 79, "911-09-98"));
            floorNeighbors.Add(new Neighbor1("Simpsons", 81, "911-09-97"));

            Console.WriteLine("Insert neighbor flat number: ");
            string flatNumber = Console.ReadLine();
            Neighbor1 foundNeighbor = floorNeighbors.Find(neighbor => neighbor.FlatNumber == Convert.ToInt32(flatNumber));
            if (foundNeighbor != null)
            {
                Console.WriteLine("Found neighbor phone: " + foundNeighbor.PhoneNumber + ", full name: " + foundNeighbor.FullName);
            }
            else
            {
                Console.WriteLine("Neighbor with flat number " + flatNumber + " not found");
            }
        }

        public class Neighbor
        {
            public string FullName { get; }

            public int FlatNumber { get; }

            public string PhoneNumber { get; }

            public Neighbor(string fullName, string phoneNumber)
            {
                this.FullName = fullName;
                this.PhoneNumber = phoneNumber;
            }
        }

        public static void DictionaryOfNeighborSearch()
        {
           Dictionary<int,Neighbor> floorNeighbors = new Dictionary<int,Neighbor>();
            floorNeighbors.Add(78, new Neighbor("Browns","911-22-23"));
            floorNeighbors.Add(79, new Neighbor("Simples", "911-22-24"));
            floorNeighbors.Add(80, new Neighbor("Simpsons", "911-22-25"));

            Console.WriteLine("Insert neighbor flat number: ");
            string flatNumber = Console.ReadLine();
            Neighbor foundNeighbor = floorNeighbors[Convert.ToInt32(flatNumber)];
            if (foundNeighbor != null)
            {
                Console.WriteLine("Found neighbor phone: " + foundNeighbor.PhoneNumber + ", full name: " + foundNeighbor.FullName);
            }
            else
            {
                Console.WriteLine("Neighbor with flat number " + flatNumber + " not found");
            }
        }

    }
}
