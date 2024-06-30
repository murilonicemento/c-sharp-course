using System;

static class Appointment
{
  public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);


  public static bool HasPassed(DateTime appointmentDate)
  {
    if (appointmentDate < DateTime.Now)
    {
      return true;
    }

    return false;
  }

  public static bool IsAfternoonAppointment(DateTime appointmentDate)
  {
    if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
    {
      return true;
    }

    return false;
  }

  public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString("G")}.";


  public static DateTime AnniversaryDate() => Appointment.Schedule("09/15/2024 00:00:00");

}
