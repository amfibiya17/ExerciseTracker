using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Exercises
{
    public class Rowing : IExercise
    {
        public int Distance { get; set; }
        public int Time { get; set; }
        public int Weight { get; set; } = 0;
        public int Sets { get; set; } = 0;
        public int Reps { get; set; } = 0;

        public string Report()
        {
            return $"Rowing: {Distance}m, {Time} minutes";
        }
    }
}
