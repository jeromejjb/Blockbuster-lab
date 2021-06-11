﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{

    public abstract class Movie
    {

        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;

        }


        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine($"Category: " + Category);
            Console.WriteLine($"Runtime: " + Runtime);
        }

        public void PrintScenes()
        {
            Console.WriteLine("Scenes: ");
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }
        }


        //Virtual == the child has the option to override it 

        public abstract void Play();

        public virtual void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i}:{scene}");

            }

        }

    }
}

