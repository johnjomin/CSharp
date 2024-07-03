namespace AnimalAppointmentVetSystem;

public class BookingService
{
    private AnimalAppointmentDuration animalAppointmentDuration;
    private Schedule schedule;

    public BookingService(AnimalAppointmentDuration animalAppointmentDuration, Schedule schedule)
    {
        this.animalAppointmentDuration = animalAppointmentDuration;
        this.schedule = schedule;
    }

    public string BookAppointment(string petName, string contactNumber, int age, string animalType)
    {
        if (!animalAppointmentDuration.IsSupported(animalType))
        {
            return "Animal type not supported";
        }

        int duration = animalAppointmentDuration.GetDuration(animalType);

        if (schedule.CanBookAppointment(duration, out DateTime appointmentTime))
        {
            Appointment appointment = new Appointment
            {
                PetName = petName,
                ContactNumber = contactNumber,
                Age = age,
                AnimalType = animalType,
                AppointmentTime = appointmentTime,
                Duration = duration
            };

            schedule.AddAppointment(appointment);

            return $"Appointment booked for {petName} at {appointmentTime.ToString("hh:mm tt")}";
        }
        else
        {
            return "No more appointments available for today";
        }
    }
}