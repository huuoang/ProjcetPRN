using System;
using System.Collections.Generic;

namespace Projcet.Models
{
    public partial class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        public int RoomId { get; set; }
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int TypeId { get; set; }
        public string Image { get; set; } = null!;

        public virtual RoomType Type { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
