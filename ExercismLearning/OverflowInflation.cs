public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        checked {
        try {
            return $"{@base * multiplier}";
        }
            catch (OverflowException) {
                return "*** Too Big ***";
            }
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        float GDP = @base * multiplier;
        return GDP == float.PositiveInfinity ? "*** Too Big ***" : $"{GDP}";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        checked {
        try {
            return $"{salaryBase * multiplier}";
        }
            catch (OverflowException) {
                return "*** Much Too Big ***";
            }
        }
    }
}
