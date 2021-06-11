using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    public class DVD : Movie
    {
        public DVD(string Title, Genre Category, int Runtime, List<string> Scenes)
            : base(Title, Category, Runtime, Scenes)
        {

        }

        public override void Play()

        {
            string userInput = "y";
            while (userInput == "y")
            {
                Console.WriteLine($"Select what scene from the DVD {this.Title} you'd like to watch : 1 to {Scenes.Count}");
                string input = Console.ReadLine();
                int index = int.Parse(input);

                string scene = Scenes[index-1];
                Console.WriteLine(scene);

                Console.WriteLine("Would you like to watch another scene (y/n)");
                userInput = Console.ReadLine();
            }


        }
    }
}