using System;
using System.Text.Json;

namespace HW._13.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new();

            song.SetSongData();

            var anon = song.GetSongData(song);
            Console.WriteLine(anon);

            string json = JsonSerializer.Serialize(anon);
            Console.WriteLine(json);
        }
    }
}