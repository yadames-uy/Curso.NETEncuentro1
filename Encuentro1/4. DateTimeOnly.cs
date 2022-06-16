namespace Encuentro1;

public class DateTimeOnly
{
    public void Ejemplo()
    {
        DateTime datetime = DateTime.Today;
        datetime.ToString();        // <------ 12/05/2022 12:00:00 o 12/05/2022 00:00:00

        DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
        dateOnly.ToString();        // <------ 12/05/2022

        TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);
        timeOnly.ToString();        // <------ 16:23
    }
}