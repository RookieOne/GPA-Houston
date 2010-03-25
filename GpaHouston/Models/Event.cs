using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using GpaHouston.Framework;

namespace GpaHouston.Models
{
    public class Event : IEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string What { get; set; }

        [Required]
        public string When { get; set; }

        [Required]
        public string Where { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        public string Description { get; set; }

        [HiddenInput]
        public long Id { get; set; }
    }
}