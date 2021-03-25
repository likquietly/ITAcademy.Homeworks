using System;

namespace HW._13.Task1
{
    class Song
    {
        enum Genre
        {
            Classic = 0,
            Rock = 1,
            Jazz = 2,
            Rap = 3,
            Pop = 4
        }

        public string Title { get; private set; }
        public int Minutes { get; private set; }
        public string Author { get; private set; }
        public int AlbumYear { get; private set; }
        Genre genre;

        public void SetSongData()
        {
            Console.WriteLine("Enter the title");
            Title = Console.ReadLine();

            Console.WriteLine("Enter minutes");
            Minutes = Validate.ValidateInt();

            Console.WriteLine("Enter author");
            Author = Console.ReadLine();

            Console.WriteLine("Enter the year the album was released");
            AlbumYear = Validate.ValidateInt();

            Console.WriteLine("Enter genre:");
            Enum.TryParse(Console.ReadLine(), out genre);
            if (!Enum.IsDefined(typeof(Genre), genre))
                genre = 0;
        }

        public dynamic GetSongData(Song song)
        {
            return new { song.Title, song.Minutes, song.Author, song.AlbumYear, song.genre };
        }
    }
}