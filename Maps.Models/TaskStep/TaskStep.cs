using Maps.Models.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maps.Models
{
    public class TaskStep : EntityBase<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLast { get; set; }
    }
}
