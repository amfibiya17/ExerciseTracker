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
