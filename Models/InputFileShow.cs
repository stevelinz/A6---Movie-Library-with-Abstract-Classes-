using System;
using System.Collections.Generic;
using System.IO;
using A6_MovieOO.Models;

namespace A6_MovieOO
{
    public class InputFileShow : Media
    {
        // properties
        public List<Media> Contents { get; }

        private readonly string _filename = Path.Combine(Environment.CurrentDirectory, "Files", "shows.csv");

        public InputFileShow()
        {
            Contents = ReadFile();
        }

        public bool Validate()
        {
            if (File.Exists(_filename))
            {
                return true;
            }
            return false;
        }
        public List<Media> ReadFile()
        {
            List<Media> media = new List<Media>();
            string[] lines = File.ReadAllLines(_filename);

            foreach (var line in lines)
            {
                var id = line.Split(',')[0];
                var title = line.Split(',')[1];
                var season = line.Split(',')[2];
                var episode = line.Split(',')[3];
                var writers = line.Split(',')[4];

                System.Console.WriteLine(id + " " + title + " " + season + " " + episode + " " + writers);
            }

            return media;
        }

        public override int Id
        {
            get
            {
                return Id;
            }
        }

        public override string Title
        {
            get
            {
                return Title;
            }
        }
        public override void Display()
        {
        }

    }
}
