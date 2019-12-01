using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.Exercise;
using ApplicationCore.Entities.User;

namespace ApplicationCore.Entities.UserExcercises
{
    class UserExcercises
    {
        public List<Excercise> UserExcercisesList { get; set; }
        public int UserId { get; set; }

    }
}
