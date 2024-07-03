namespace AnimalAppointmentVetSystem
{
    public class Appointment
    {
        public string PetName { get; set; }
        public string ContactNumber { get; set; }
        public int Age { get; set; }
        public string AnimalType { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int Duration { get; set; }
    }
}