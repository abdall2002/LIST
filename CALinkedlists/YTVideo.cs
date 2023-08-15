using System;

namespace CALinkedlists
{
    public class YTVideo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            // C# Variables (00:30:00)
            //      https://www.youtube.com/watch?v=d6EpL33g9tg
            return $"├── {Title} ({Duration})\n│\thttps://www.youtube.com/watch?v={Id}";
        }
    }
    
}
