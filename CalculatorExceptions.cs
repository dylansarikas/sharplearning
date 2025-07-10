public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        try
        {
            if (operation == "")
            {
                throw new ArgumentException();
            }
            else if (operation == null)
            {
                throw new ArgumentNullException();
            }
            else if (operation != "+" && operation != "/" && operation != "*")
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (operation == "+")
            {
                return $"{operand1} + {operand2} = {operand1 + operand2}";
            }
            else if (operation == "*")
            {
                return $"{operand1} * {operand2} = {operand1 * operand2}";
            }
            else if (operation == "/")
            {
                if (operand2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return $"{operand1} / {operand2} = {operand1 / operand2}";
            }
        }
        catch (DivideByZeroException)
        {
            return "Division by zero is not allowed.";
        }
        return "oops";
    }
}





public static class SimpleOperation
{
    public static int Division(int operand1, int operand2)
    {
        return operand1 / operand2;
    }

    public static int Multiplication(int operand1, int operand2)
    {
        return operand1 * operand2;
    }

    public static int Addition(int operand1, int operand2)
    {
        return operand1 + operand2;
    }
}
