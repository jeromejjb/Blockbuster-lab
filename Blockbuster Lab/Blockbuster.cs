using System;
using System.Collections.Generic;
using System.Text;


namespace Blockbuster_Lab
{
    class BlockBusterVideo
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        //You may only initialize values, but you may call any methods outside of another method
        //Directly in a class, you may only declare and initalize properties and declare methods/constructors

        public BlockBusterVideo()
        {
            //Think of this constructor as stocking our shelves in block buster with Movies
            List<string> deadPoetSociety = new List<string>() { "Welcome to Welton Academy", "Meeting Mr. Keeting", "Neals Triumph", "The Fall out" };
            DVD dps = new DVD("Dead Poet Socity", Genre.Drama, 120, deadPoetSociety);


            List<string> goodFellas = new List<string>() { "Henry's introduction to Mob life", "Henry's first pinch", "Henry in prison", "Henry becomes a rat" };
            DVD gf = new DVD("Goodfellas", Genre.Action, 190, goodFellas);



            List<string> theSocialNetwork = new List<string>() { "Mark breaks up with Erica", "Mark hacks harvard", "Mark builds facebook", "Mark gets settles in court" };
            VHS tsn = new VHS("The Social Network", Genre.Action, 120, theSocialNetwork);

            List<string> godFather = new List<string>() { "The Don takes care of business", "The meeting of 5 families", "The war of the families", "Michael takes over the family business" };
            VHS gff = new VHS("God Father", Genre.Drama, 225, godFather);

            Movies.Add(dps);
            Movies.Add(gf);
            Movies.Add(tsn);
            Movies.Add(gff);
        }

        //2 Reasons why we can use the movie class
        //1) Movie is public 
        //2) Movie is in the same namespace as this class
        public Movie GetMovie(int index)
        {
            Movie m = Movies[index-1];
            return m;
        }


        public void PrintAllMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                string title = m.Title;
                Console.WriteLine($"{i+1}: {title}");
            }
        }

        public void Checkout()
        {
            Console.WriteLine($"What movie would you like to watch? 1 to {Movies.Count - 0}");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            

            Movie m = GetMovie(index);
            Console.WriteLine($"Title: {m.Title}");
            Console.WriteLine($"Category: {m.Category}");
            Console.WriteLine($"Runtime: {m.Runtime}");

            Console.WriteLine("Do you want to watch the movie? (y/n)");
            string userInput = Console.ReadLine();

            m.Play();

            Console.WriteLine("bye");

            

            
        }
    }
}