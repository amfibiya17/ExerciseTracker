namespace ExerciseTracker.Exercises
{
    public class Rowing : IDistanceExercise
    {
        public override string Report()
        {
            return $"Rowing: {Distance}m, {Time} minutes";
        }
    }
}
