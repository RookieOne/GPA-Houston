using GpaHouston.Framework;

namespace GpaHouston.Models
{
    public class News : IEntity
    {
        public string Title { get; set; }
        public string Html { get; set; }
        public long Id { get; set; }
    }
}