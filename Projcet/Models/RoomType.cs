using System;
using System.Collections.Generic;

namespace Projcet.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            Rooms = new HashSet<Room>();
        }

        public int TypeId { get; set; }
        public string Name { get; set; } = null!;
        public int Acreage { get; set; }
        public int Beds { get; set; }
        public int Bathrooms { get; set; }
        public int Capacity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
