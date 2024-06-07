using System;

public class Appointment
{
    public int AppointmentId { get; set; }
    public DateTime? AppointmentDate { get; set; }
    public TimeSpan? AppointmentTime { get; set; }
    public int? OwnerId { get; set; }
    public int? PetId { get; set; }
    public int? VetId { get; set; }
    public string Reason { get; set; }
    public string Status { get; set; }
}
