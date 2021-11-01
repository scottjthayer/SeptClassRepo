using System;
using System.Collections.Generic;

#nullable disable

namespace EfMvcDbFirst
{
    public partial class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public bool? SoldOut { get; set; }
    }
}
