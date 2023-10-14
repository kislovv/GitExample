using System.Collections;

namespace OOP.Classes;

public class StudentComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x != null || y != null)
        {
            if (x is Student fStudent && y is Student sStudent)
            {
                var fage = fStudent.GetAge();
                var sage = sStudent.GetAge();
                return fage > sage
                    ? 1
                    : fage < sage
                        ? -1
                        : 0;
            }

            throw new ArgumentException();
        }

        throw new ArgumentException();
    }
}