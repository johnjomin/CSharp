namespace AnimalAppointmentVetSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            AnimalAppointmentService animalAppointmentService = new AnimalAppointmentService();
            Schedule schedule = new Schedule();
            BookingService bookingService = new BookingService(animalAppointmentService, schedule);

            Console.WriteLine(bookingService.BookAppointment("Buddy", "1234567890", 5, "Dog", true));
            Console.WriteLine(bookingService.BookAppointment("Whiskers", "0987654321", 3, "Cat", false));
            Console.WriteLine(bookingService.BookAppointment("Fluffy", "5551234567", 2, "Rabbit", true));
            Console.WriteLine(bookingService.BookAppointment("Max", "4445556666", 4, "Dog", false));
            Console.WriteLine(bookingService.BookAppointment("Bella", "3334445555", 1, "Cat", true));

            schedule.PrintAppointments();
            Console.WriteLine("Total Cost: " + bookingService.CalculateTotalCost());
            Console.WriteLine($"Average Duration: {bookingService.CalculateAverageDuration()} and Average Cost: {bookingService.CalculateAverageCost()}");
        }
    }
}