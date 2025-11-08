using System.Collections;

namespace OOP.Classes;

public class StudentComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x == null && y == null)
        {
            return 0;
        }

        if (x == null)
        {
            return -1;
        }

        if (y == null)
        {
            return 1;
        }

        if (x is not Student firstStudent || y is not Student secondStudent)
        {
            throw new ArgumentException("Both students must be of the same type");
        }
        
        return firstStudent.LevelOfKnowledge.CompareTo(secondStudent.LevelOfKnowledge);
    }
}