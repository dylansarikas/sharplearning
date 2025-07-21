using System;
using System.Globalization;

class WeighingMachine
{
    public int Precision { get; }

    public double TareAdjustment { get; set; } = 5.0;

    private double _weight;
    public double Weight
    {
        get { return _weight; }
        set 
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();

            _weight = value;
        }
    }

    public string DisplayWeight
    {
        get{
            var format = new NumberFormatInfo();
            format.NumberDecimalDigits = Precision;
            string adjustedWeight = (Weight - TareAdjustment).ToString("f", format);
            return $"{adjustedWeight} kg";
        }
    }

    public WeighingMachine(int precision) => this.Precision = precision;
}
