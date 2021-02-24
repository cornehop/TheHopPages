using System.Collections.Generic;

namespace TheHopPages.Models
{
    public class Category
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public ICollection<Page> Items { get; set; }
    }
}
