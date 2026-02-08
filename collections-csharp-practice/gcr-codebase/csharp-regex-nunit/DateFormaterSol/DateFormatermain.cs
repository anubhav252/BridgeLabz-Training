using System;
using System.Globalization;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (!DateTime.TryParseExact(
                inputDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime parsedDate))
        {
            throw new FormatException("Invalid date format");
        }

        return parsedDate.ToString("dd-MM-yyyy");
    }
}
