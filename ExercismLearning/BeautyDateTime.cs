using System;
using System.Runtime.InteropServices;
using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    private static string GetTimeZoneID(this Location salonLocation)
    {
        switch (salonLocation)
        {
            case Location.Paris:
                return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "W. Europe Standard Time" : "Europe/Paris";
            case Location.NewYork:
                return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "Eastern Standard Time" : "America/New_York";
            case Location.London:
                return RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "GMT Standard Time" : "Europe/London";
            default:
                return "";
        }
    }

    private static TimeZoneInfo GetTimeZoneInfo(this Location salonLocation) => TimeZoneInfo.FindSystemTimeZoneById(salonLocation.GetTimeZoneID());
    
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var parsedDate = DateTime.Parse(appointmentDateDescription);
        return TimeZoneInfo.ConvertTimeToUtc(parsedDate, location.GetTimeZoneInfo());
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        switch (alertLevel)
        {
            case AlertLevel.Early:
                return appointment.AddDays(-1);
            case AlertLevel.Standard:
                return appointment.AddHours(-1.75);
            case AlertLevel.Late:
                return appointment.AddMinutes(-30);
            default:
                return appointment;
        }
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location) => location.GetTimeZoneInfo().IsDaylightSavingTime(dt) != location.GetTimeZoneInfo().IsDaylightSavingTime(dt.AddDays(-7));

    private static CultureInfo GetCultureInfo(this Location salonLocation)
    {
        switch (salonLocation)
        {
             case Location.NewYork:
                return new CultureInfo("en-US");
            case Location.London:
                return new CultureInfo("en-GB");
            case Location.Paris:
                return new CultureInfo("fr-FR");
            default:
                return new CultureInfo("fr-FR");
        }
            
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        DateTime normalizedTime;

        DateTime.TryParse(dtStr, location.GetCultureInfo(), out normalizedTime);
        return normalizedTime;
    }
}
