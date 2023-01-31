using ExerciseTracker.Exercises;

namespace ExerciseTracker
{
    public interface IExercise
    {
        
        string Report();
        int Weight { get; set; }
        int Sets { get; set; }
        int Reps { get; set; }
        int Distance { get; set; }
        int Time { get; set; }
    }
}