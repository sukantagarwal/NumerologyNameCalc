namespace NumerologyNameCalc.Services
{
    using System;
    //using NumerologyNameCalc.Repository;
    public class NameService //: INameRepository
    {
        //private readonly INameRepository _nameRepository;

        // public NameService(INameRepository nameRepository)
        // {
        //     _nameRepository = nameRepository;
        // }

        public int CalulateNumerologyForName(string _name)
        {
            var _total = (double)CalculateTotalNumber(_name);
            return (int)CalculateSumOfTotal(_total);
        }

        public int CalculateTotalNumber(string _name)
        {
            var _nameLength = _name.Length;
            var _total = 0;
            var _nameInArray = _name.ToCharArray();
            for(var _indexOfArray = 0; _indexOfArray < _nameLength; _indexOfArray++)
            {
                _total = _total + GetNumberForCharacter(_nameInArray[_indexOfArray]);
            }

            return _total;
        }

        public double CalculateSumOfTotal(double _total)
        {
            var _divisor = Math.Pow(10,_total.ToString().Length - 1);
            double _finalResult = 0;
            double _singleNumber = 0;
            while(_divisor !=1)
            {
                _singleNumber = _total % _divisor;
                _finalResult = _finalResult + _singleNumber;
                _total = _total / _divisor;
                _divisor = _divisor / 10;
            }

            return _finalResult + _singleNumber;
        }
        

        public int GetNumberForCharacter(char alphabet)
        {
            switch(alphabet)
            {
                case 'a': case 'A': case 'i': case 'I': case 'j': case 'J': case 'q': case 'Q': case 'y': case 'Y':
                    return 1;
                case 'b': case 'B': case 'k': case 'K': case 'r': case 'R':
                    return 2;
                case 'c': case 'C': case 'l': case 'L': case 's': case 'S':
                    return 3;
                case 'd': case 'D': case 'm': case 'M': case 't': case 'T':
                    return 4;
                case 'e': case 'E': case 'h': case 'H': case 'n': case 'N': case 'x': case 'X':
                    return 5;
                case 'f': case 'F': case 'p': case 'P':
                    return 8;
                case 'u': case 'U': case 'v': case 'V':case 'w': case 'W':
                    return 6;
                case 'o': case 'O': case 'z': case 'Z':
                    return 7;
                default:
                    return 0;
            }
        }
    }   

}