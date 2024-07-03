namespace AnimalAppointmentVetSystem;

public class AnimalAppointmentDuration
{
    private readonly Dictionary<string, int> animalAppointmentDurations = new Dictionary<string, int>()
    {
        {"Dog", 60},
        {"Cat", 45},
        {"Rabbit", 30}
    };

    public int GetDuration(string animalType)
    {
        if (animalAppointmentDurations.ContainsKey(animalType))
        {
            return animalAppointmentDurations[animalType];
        }
        throw new ArgumentException("Animal type not supported");
    }

    public bool IsSupported(string animalType)
    {
        return animalAppointmentDurations.ContainsKey(animalType);
    }
}