namespace AnimalAppointmentVetSystem;

public class BookingService
{
    private AnimalAppointmentService animalAppointmentService;
    private Schedule schedule;

    public BookingService(AnimalAppointmentService animalAppointmentService, Schedule schedule)
    {
        this.animalAppointmentService = animalAppointmentService;
        this.schedule = schedule;
    }

    public string BookAppointment(string petName, string contactNumber, int age, string animalType, bool isMember)
    {
        if (!animalAppointmentService.IsSupported(animalType))
        {
            return "Animal type not supported";
        }

        var animalDetails = animalAppointmentService.GetDetails(animalType);
        var duration = animalDetails.Duration;
        var cost = isMember ? animalDetails.CostForMembers : animalDetails.CostForNonMembers;

        if (schedule.CanBookAppointment(duration, out DateTime appointmentTime))
        {
            Appointment appointment = new Appointment
            {
                PetName = petName,
                ContactNumber = contactNumber,
                Age = age,
                AnimalType = animalType,
                AppointmentTime = appointmentTime,
                Duration = duration,
                IsMember = isMember,
                Cost = cost
            };

            schedule.AddAppointment(appointment);

            return $"Appointment booked for {petName} at {appointmentTime.ToString("hh:mm tt")}";
        }
        else
        {
            return "No more appointments available for today";
        }
    }

    public int CalculateTotalCost()
    {
        int totalCost = 0;
        foreach (var appointment in schedule.GetAppointments())
        {
            totalCost += appointment.Cost;
        }

        return totalCost;
    }
    
    public int CalculateTotalDuration()
    {
        int totalDuration = 0;
        foreach (var appointment in schedule.GetAppointments())
        {
            totalDuration += appointment.Duration;
        }

        return totalDuration;
    }

    public int CalculateAverageCost()
    {
        var appointments = schedule.GetAppointments();
        if (appointments.Count == 0)
            return 0;

        var totalCost = CalculateTotalCost();

        return totalCost / appointments.Count;
    }
    
    public int CalculateAverageDuration()
    {
        var appointments = schedule.GetAppointments();
        if (appointments.Count == 0)
            return 0;

        var totalDuration = CalculateTotalDuration();

        return totalDuration / appointments.Count;
    }

    public void GenerateReport()
    {
        var totalAppointments = schedule.GetAppointments();
        var report = new Dictionary<string, (int count, int totalDuration, int cost)>();

        foreach (var appointment in totalAppointments)
        {
            
        }

    }
}