namespace MusicHub
{
    using System;
    using System.Text;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using MusicHub.Data.Models;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here
            //Console.WriteLine(ExportAlbumsInfo(context, 9));
            Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var result = context.Producers
                .Include(x => x.Albums)
                .ThenInclude(a => a.Songs)
                .ThenInclude(s => s.Writer)
                .First(x => x.Id == producerId)
                .Albums.Select(x => new
                {
                    x.Name,
                    ReleaseDate = x.ReleaseDate,
                    ProducerName = x.Producer.Name,
                    Songs = x.Songs.Select(x => new
                    {
                        x.Name,
                        x.Price,
                        SongWriterName = x.Writer.Name,

                    })
                    .OrderByDescending(x => x.Name).ThenBy(x => x.SongWriterName),
                    TotalPrice = x.Price
                })
                .OrderByDescending(x => x.TotalPrice)
                .AsEnumerable();

            StringBuilder sb = new();
            foreach (var s in result)
            {
                sb.AppendLine($"-AlbumName: {s.Name}");
                sb.AppendLine($"-ReleaseDate: {s.ReleaseDate:MM/dd/yyyy}");
                sb.AppendLine($"-ProducerName: {s.ProducerName}");
                int count = 0;
                sb.AppendLine($"-Songs:");
                foreach (var v in s.Songs)
                {
                    count++;
                    sb.AppendLine($"---#{count}");
                    sb.AppendLine($"---SongName: {v.Name}");
                    sb.AppendLine($"---Price: {v.Price:f2}");
                    sb.AppendLine($"---Writer: {v.SongWriterName}");
                }
                sb.AppendLine($"-AlbumPrice: {s.TotalPrice:f2}");
            }

            return sb.ToString().Trim();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var result = context.Songs
                .Include(s => s.SongPerformers)
                .ThenInclude(sp => sp.Performer)
                .Include(s => s.Writer)
                .Include(s => s.Album)
                .ThenInclude(a => a.Producer)
                .ToList()
                .Where(s => s.Duration.TotalSeconds > duration)
                .Select(x => new
                {
                    x.Name,
                    Performer = x.SongPerformers
                    .Select(sp => new
                    {
                        sp.Performer.FirstName,
                        sp.Performer.LastName
                    })
                    .ToList().OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName),
                    WriterName = x.Writer.Name,
                    AlbumProducer = x.Album.Producer,
                    Duration = x.Duration.ToString("c"),
                })
                .OrderBy(x => x.Name).ThenBy(x => x.WriterName).ThenBy(x=>x.Performer).ToList();

            StringBuilder sb = new();
            int count = 0;
            foreach(var s in result)
            {
                count++;
                sb.AppendLine($"-Song #{count}");
                sb.AppendLine($"---SongName: {s.Name}");
                sb.AppendLine($"---Writer: {s.WriterName}");   
                if(s.Performer.Any())
                {
                    foreach(var p in s.Performer)
                    {
                        sb.AppendLine($"---Performer: {p.FirstName} {p.LastName}");
                    }                
                }                
                sb.AppendLine($"---AlbumProducer: {s.AlbumProducer.Name}");
                sb.AppendLine($"---Duration: {s.Duration}");
            }

            return sb.ToString().Trim();
        }
    }
}
