using FluentNHibernate.Mapping;
using GpaHouston.Data.Dtos;

namespace GpaHouston.Data.Maps
{
    public class AvailableDogMap : ClassMap<AvailableDog>
    {
        public AvailableDogMap()
        {
            Table("AvailableDogs");

            Id(d => d.Id, "Id");
            Map(d => d.Name, "Name");
        }
    }
}