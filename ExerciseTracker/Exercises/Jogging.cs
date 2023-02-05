using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Exercises
{
    public class Jogging : IDistanceExercise
    {
        public override string Report()
        {
            return $"Jogging: {Distance}m, {Time} minutes";
        }
    }
}
