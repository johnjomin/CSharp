namespace AnimalAppointmentVetSystem;

public class Schedule
{
    private List<Appointment> appointments = new List<Appointment>();
    private DateTime startTime = DateTime.Today.AddHours(9); // 9:00 AM
    private DateTime endTime = DateTime.Today.AddHours(17); // 5:00 PM

    public bool CanBookAppointment(int duration, out DateTime appointmentTime)
    {
        DateTime currentTime = startTime;

        foreach (var appointment in appointments)
        {
            if (currentTime >= appointment.AppointmentTime && currentTime < appointment.AppointmentTime.AddMinutes(appointment.Duration))
            {
                currentTime = appointment.AppointmentTime.AddMinutes(appointment.Duration);
            }
        }

        if (currentTime.AddMinutes(duration) > endTime)
        {
            appointmentTime = DateTime.MinValue; // No available time slot
            return false;
        }

        appointmentTime = currentTime;
        return true;
    }

    public void AddAppointment(Appointment appointment)
    {
        appointments.Add(appointment);
    }

    public void PrintAppointments()
    {
        foreach (var appointment in appointments)
        {
            Console.WriteLine($"{appointment.PetName} ({appointment.AnimalType}) - {appointment.AppointmentTime.ToString("hh:mm tt")}, Duration: {appointment.Duration} minutes");
        }
    }
}