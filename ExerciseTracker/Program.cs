using ExerciseTracker.Exercises;

namespace ExerciseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We'll use some dummy data for now. Annoyingly, there are loads of errors here, let's fix them!
            IExercise[] exercisesCompleted = new IExercise[] {
                new Deadlift { Reps = 5, Sets = 2, Weight = 35 },
                new Jogging { Distance = 2, Time = 20 },
                new Squat { Reps = 10, Sets = 4, Weight = 12 },
                new Rowing { Distance = 1000, Time = 6 }
            };

            foreach (var exercise in exercisesCompleted)
            {
                //this is also giving an error, what's wrong here?
                Console.WriteLine(exercise.Report());
            }

            // I'd also like to know the total weight lifted, and the total distance travelled - how can we manage those?
            int totalWeightLifted = 0;
            int totalDistanceTravelled = 0;
            foreach (var exercise in exercisesCompleted)
            {
                if (exercise is IWeightsExercise weights)
                {
                    totalWeightLifted += weights.Weight;
                }
                
                if (exercise is IDistanceExercise distanceExercise)
                {
                    totalDistanceTravelled += distanceExercise.Distance;
                }
            }

            Console.WriteLine($"Total weight lifted: {totalWeightLifted}");
            Console.WriteLine($"Total distance traveled: {totalDistanceTravelled}");

            Console.ReadLine();
        }
    }
}