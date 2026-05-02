using System;

namespace ClassWork;

public class AssertionException: Exception
{
    public AssertionException(string message): base(message)
    {
        
    }
}