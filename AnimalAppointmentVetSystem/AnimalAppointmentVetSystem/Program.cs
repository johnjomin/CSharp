namespace AnimalAppointmentVetSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            AnimalAppointmentDuration animalAppointmentDuration = new AnimalAppointmentDuration();
            Schedule schedule = new Schedule();
            BookingService bookingService = new BookingService(animalAppointmentDuration, schedule);

            Console.WriteLine(bookingService.BookAppointment("Buddy", "1234567890", 5, "Dog"));
            Console.WriteLine(bookingService.BookAppointment("Whiskers", "0987654321", 3, "Cat"));
            Console.WriteLine(bookingService.BookAppointment("Fluffy", "5551234567", 2, "Rabbit"));
            Console.WriteLine(bookingService.BookAppointment("Max", "4445556666", 4, "Dog"));
            Console.WriteLine(bookingService.BookAppointment("Bella", "3334445555", 1, "Cat"));

            schedule.PrintAppointments();
        }
    }
}