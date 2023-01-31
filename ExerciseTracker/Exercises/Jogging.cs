using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Exercises
{
    public class Jogging : IExercise
    {
        public int Distance { get; set; }
        public int Time { get; set; }

        public string Report()
        {
            return $"Jogging: {Distance} distance, {Time} time";
        }
    }
}
