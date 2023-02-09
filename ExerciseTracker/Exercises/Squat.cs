namespace ExerciseTracker.Exercises
{
    public class Squat : IWeightsExercise
    {
        public override string Report()
        {
            return $"Squats: {Reps} reps, {Sets} sets, {Weight}kg";
        }
    }
}
