using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//Vitalii Bobyr - 06/16/24"
//Programming 120 - Code Practice - Lecture 12 Classes"

namespace Сonsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Exercise[] exercises = new Exercise[5];

            
            exercises[0] = new Exercise("Push-up", 20, 0.0);
            exercises[1] = new Exercise("Squat", 15, 0.0);
            exercises[2] = new Exercise("Bench Press", 10, 75.5);
            exercises[3] = new Exercise("Deadlift", 8, 100.0);
            exercises[4] = new Exercise("Bicep Curl", 12, 15.0);
                                      
            Exercise exerciseInstance = new Exercise();
            exerciseInstance.DisplayAllExercises(exercises);

        }
    }


    class Exercise
    {
        string Name;
        int Reps;
        double Weight;

        public Exercise ()
        {
            Name = "No Exercise";
            Reps = -1;
            Weight = -1;
        }

        public Exercise(string name, int reps, double weight)
        {
            Name = name;
            Reps = reps;
            Weight = weight;
        }

        public void DisplayExercise(Exercise exercise)
        {
            Console.WriteLine($"{exercise.Name}|{exercise.Reps}|{exercise.Weight}");
        }

        public void DisplayAllExercises(Exercise[] exercises)
        {
            Console.WriteLine("Name of Exercises - Reps - Weight");
            for (int i = 0; i < exercises.Length; i++)
            {
                Console.WriteLine($"{exercises[i].Name}|{exercises[i].Reps}|{exercises[i].Weight}");
            }
        }
    }
}
