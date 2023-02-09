namespace ExerciseTracker.Exercises
{
    public class Deadlift: IWeightsExercise
    {
        public override string Report()
        {
            return $"Deadlift: {Reps} reps, {Sets} sets, {Weight}kg";
        }
    }
}
