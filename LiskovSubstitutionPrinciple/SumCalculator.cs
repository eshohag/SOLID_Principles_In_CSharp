using System.Linq;

namespace LiskovSubstitutionPrinciple
{
    class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate()
        {
            return _numbers.Sum();
        }
    }
}
