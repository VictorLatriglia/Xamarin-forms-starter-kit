using System;
using System.Collections.Generic;
using System.Text;

namespace Maps.Models.Generics
{
    public class EntityBase<Tid> : EntityBaseWithTypedId<Tid>
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public EntityBase()
        {
            CreatedOn = DateTime.UtcNow.AddHours(-5);
            UpdatedOn = DateTime.UtcNow.AddHours(-5);
        }
    }
}
