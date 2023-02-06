namespace ExerciseTracker.Exercises
{
    public abstract class IWeightsExercise : IExercise
    {
        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
       
        public int TotalLifted()
        {
            return Reps * Sets * Weight;
        }

        public abstract string Report();
    }
}