namespace ExerciseTracker.Exercises
{
    public abstract class IDistanceExercise : IExercise
    {
        public int Distance { get; set; }
        public int Time { get; set; }
        public abstract string Report();
    }
}