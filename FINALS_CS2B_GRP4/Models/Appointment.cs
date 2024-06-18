using System;

public class Appointment
{
    // Appointment ID
    public int AppointmentId { get; set; }

    // Appointment Date
    public DateTime? AppointmentDate { get; set; }

    // Appointment Time
    public TimeSpan? AppointmentTime { get; set; }

    // Owner ID
    public int? OwnerId { get; set; }

    // Pet ID
    public int? PetId { get; set; }

    // Vet ID
    public int? VetId { get; set; }

    // Reason for the appointment
    public string Reason { get; set; }

    // Status of the appointment
    public string Status { get; set; }
}
