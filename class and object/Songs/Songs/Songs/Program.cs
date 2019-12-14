using System;
using System.Linq;
using System.Collections.Generic;

namespace Songs
{
    class Song
    {
        public string typyList { get; set; }
        public string name { get; set; }
        public string time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> MusicList = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("_").ToArray();

                Song newSong = new Song()
                {
                    typyList = data[0],
                    name = data[1],
                    time=data[2]

                };

                MusicList.Add(newSong);
            }


            string typeFavority = Console.ReadLine();

            foreach (Song item in MusicList)
            {
                if (typeFavority==item.typyList)
                {
                    Console.WriteLine(item.name);
                }
                else 
                {
                    Console.WriteLine(item.name);
                }
            }
        }
    }
}
