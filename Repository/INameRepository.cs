namespace NumerologyNameCalc.Repository
{
    public interface INameRepository
    {
        int CalulateNumerologyForName(string _name); 
        int CalculateTotalNumber(string _name);
        double CalculateSumOfTotal(double _total);
        int GetNumberForCharacter(char alphabet);
    }
}