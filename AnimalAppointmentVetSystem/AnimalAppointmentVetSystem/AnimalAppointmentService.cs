namespace AnimalAppointmentVetSystem;

public class AnimalAppointmentService
{
    private readonly Dictionary<string, AppointmentDetails> animalDetails = new Dictionary<string, AppointmentDetails>()
    {
        {"Dog", new AppointmentDetails {Duration = 60, CostForMembers = 100, CostForNonMembers = 150}},
        {"Cat", new AppointmentDetails {Duration = 45, CostForMembers = 75, CostForNonMembers = 125}},
        {"Rabbit", new AppointmentDetails {Duration = 30, CostForMembers = 50, CostForNonMembers = 100}}
    };

    public AppointmentDetails GetDetails(string animalType)
    {
        if (animalDetails.ContainsKey(animalType))
        {
            return animalDetails[animalType];
        }
        throw new ArgumentException("Animal type not supported");
    }

    public bool IsSupported(string animalType)
    {
        return animalDetails.ContainsKey(animalType);
    }
}