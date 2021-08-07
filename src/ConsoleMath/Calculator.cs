using System;

namespace ConsoleMath
{
    public class Calculator
    {
        public int SimpleMathCalculation(int firstValue, int secondValue, OperationEnum operation)
        {
            switch (operation)
            {
                case OperationEnum.addition:
                    return firstValue + secondValue;
                case OperationEnum.subtraction:
                    return firstValue - secondValue;
                case OperationEnum.division:
                    return firstValue / secondValue;
                case OperationEnum.multiplication:
                    return firstValue * secondValue;
                default:
                    throw new Exception("Entered operation is incorrect");
            };
        }
    }
}
