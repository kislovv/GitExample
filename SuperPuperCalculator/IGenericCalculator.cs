namespace SuperPuperCalculator;

public interface IGenericCalculator<TOperand>
{
    TOperand Add(TOperand a, TOperand b);
    TOperand Subtract(TOperand a, TOperand b);
    TOperand Multiply(TOperand a, TOperand b);
    TOperand Divide(TOperand a, TOperand b);
}