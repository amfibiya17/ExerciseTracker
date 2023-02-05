namespace ExerciseTracker.Exercises
{
    public abstract class IDistanceExercise : IExercise
    {
        public int Distance { get; set; }
        public int Time { get; set; }
        public int Weight { get; set; } = 0;
        public int Sets { get; set; } = 0;
        public int Reps { get; set; } = 0;

        public abstract string Report();
    }
}