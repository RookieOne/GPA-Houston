using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using GpaHouston.Framework;

namespace GpaHouston.Models
{
    public class AvailableDog : IEntity
    {
        [HiddenInput]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}