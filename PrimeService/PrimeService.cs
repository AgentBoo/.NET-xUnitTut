using System;

// first create a failing implementation of the PrimeService class 
namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }
    }
}
