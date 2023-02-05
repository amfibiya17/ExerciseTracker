namespace ExerciseTracker.Exercises
{
    public abstract class IWeightsExercise : IExercise
    {
        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Distance { get; set; } = 0;
        public int Time { get; set; } = 0;
        
        public int TotalLifted()
        {
            return Reps * Sets * Weight;
        }

        public abstract string Report();
    }
}