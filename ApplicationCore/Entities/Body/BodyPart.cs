using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

namespace ApplicationCore.Entities.ExerciseAggregate
{
   public class BodyPart : BaseEntity
    {
        public int BodyPartId { get; set; }
        public string BodyPartName { get; set; }
      
    }
}
