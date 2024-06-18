using System;

public class Pet
{
    // Represents the unique identifier of the pet
    public int PetId { get; set; }

    // Represents the name of the pet
    public string Name { get; set; }

    // Represents the species of the pet
    public string Species { get; set; }

    // Represents the breed of the pet
    public string Breed { get; set; }

    // Represents the birth date of the pet (nullable)
    public DateTime? BirthDate { get; set; }

    // Represents the owner's identifier of the pet (nullable)
    public int? OwnerId { get; set; }
}
