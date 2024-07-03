# AnimalAppointmentVetSystem
A small veterinary practice requires a computerised appointments booking system for animals visiting the practice.
At the moment there is only one vet and the only animals the practice sees along with the time required for an appointment is
shown below:

| Animal | Appointment time required |
| ------ | ------ |
| Dog | 60 minutes |
| Cat | 45 minutes |
| Rabbit  | 30 minutes |

Soon the system will need to deal with more animals so solution should be easily cope with this requirement.

Appointments start at 9:00am and finish at 5:00pm, there is no lunch period.

There are no advance appointments and people call up in the morning to request an appointment for that day. 
The input received for each appointment is the name of the pet, contact telephone number, age and type of animal. 
The output is a time for the appointment or if no time left indicates there are no more appointments.

## Feature 1
Allocate appointments for the different animals and demonstrate how to populate a day with appointments for multiple animal types.
A list of allocated appointments should be maintained.

## Feature 2
Any appointment should finish on or before 5:00pm.
Write code to enforce this constraint and demonstrate that is works as expected.