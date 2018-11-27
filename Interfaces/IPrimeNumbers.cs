using System.Collections.Generic;

namespace IsItASemiPrimeNumber.Interfaces
{
    public interface IPrimeNumbers
    {
        List<int> GetPrimeNumbers(int limit);
        bool IsPrimeNumber(int number);
    }
}
