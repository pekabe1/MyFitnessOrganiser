using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.Exercise;

namespace ApplicationCore.Entities.ExerciseAggregate
{
    public class ExcerciseType : Excercise
    {
        public int ExcerciseTypeId { get; set; }
        public string ExcerciceName { get; set; }
    }
}
