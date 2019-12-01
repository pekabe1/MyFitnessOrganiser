using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.ExerciseAggregate;

namespace ApplicationCore.Entities.Exercise
{
    public class Excercise : BaseEntity
    {
        public string Name { get; set; }  
        public string Discription { get; set; }
        public int ExcerciseTypeId { get; set; }
        public ExcerciseType ExcerciseType;
        public int BodyPartId { get; set; }
        public BodyPart BodyPart { get; set; }
    }
}
