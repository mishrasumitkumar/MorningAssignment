namespace MorningAssignment;

internal class LengthConverter
{
    protected double centimeters;

    public LengthConverter(double cm)
    {
        centimeters = cm;
    }

    public double ConvertToMeters()
    {
        return centimeters / 100;
    }

    public double ConvertToKilometers()
    {
        return centimeters / 100000;
    }
}
