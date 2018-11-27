using System.Collections.Generic;

namespace IsItASemiPrimeNumber.Interfaces
{
    public interface ISemiPrimeNumbers
    {
        List<int> GetSemiPrimeNumbers(List<int> primeNumbers, int limit);
    }
}
