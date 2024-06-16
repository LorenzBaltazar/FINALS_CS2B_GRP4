using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALS_CS2B_GRP4
{
    internal class DatabaseHelper
    {
        private static string connectionString = "server=localhost;user id=root;password=;database=vetis_db";

		public static DataTable SelectAllAppointments()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM appointments";
                var command = new MySqlCommand(query, connection);
                var dataTable = new DataTable();
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
        }

        public static void CreateAppointment(Appointment appointment)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "INSERT INTO appointments (appointment_date, appointment_time, owner_id, pet_id, vet_id, reason, status) VALUES (@AppointmentDate, @AppointmentTime, @OwnerId, @PetId, @VetId, @Reason, @Status)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
                command.Parameters.AddWithValue("@OwnerId", appointment.OwnerId);
                command.Parameters.AddWithValue("@PetId", appointment.PetId);
                command.Parameters.AddWithValue("@VetId", appointment.VetId);
                command.Parameters.AddWithValue("@Reason", appointment.Reason);
                command.Parameters.AddWithValue("@Status", appointment.Status);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static Appointment ReadAppointment(int appointmentId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM appointments WHERE appointment_id = @AppointmentId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AppointmentId", appointmentId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Appointment
                        {
                            AppointmentId = reader.GetInt32("appointment_id"),
                            AppointmentDate = reader.GetDateTime("appointment_date"),
                            AppointmentTime = reader.GetTimeSpan("appointment_time"),
                            OwnerId = reader.IsDBNull(reader.GetOrdinal("owner_id")) ? (int?)null : reader.GetInt32("owner_id"),
                            PetId = reader.IsDBNull(reader.GetOrdinal("pet_id")) ? (int?)null : reader.GetInt32("pet_id"),
                            VetId = reader.IsDBNull(reader.GetOrdinal("vet_id")) ? (int?)null : reader.GetInt32("vet_id"),
                            Reason = reader.GetString("reason"),
                            Status = reader.GetString("status")
                        };
                    }
                    return null;
                }
            }
        }

        public static void UpdateAppointment(Appointment appointment)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "UPDATE appointments SET appointment_date = @AppointmentDate, appointment_time = @AppointmentTime, owner_id = @OwnerId, pet_id = @PetId, vet_id = @VetId, reason = @Reason, status = @Status WHERE appointment_id = @AppointmentId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId);
                command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                command.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);
                command.Parameters.AddWithValue("@OwnerId", appointment.OwnerId);
                command.Parameters.AddWithValue("@PetId", appointment.PetId);
                command.Parameters.AddWithValue("@VetId", appointment.VetId);
                command.Parameters.AddWithValue("@Reason", appointment.Reason);
                command.Parameters.AddWithValue("@Status", appointment.Status);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteAppointment(int appointmentId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "DELETE FROM appointments WHERE appointment_id = @AppointmentId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@AppointmentId", appointmentId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
		
		public static DataTable SelectAllOwners()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM owners";
                var command = new MySqlCommand(query, connection);
                var dataTable = new DataTable();
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
        }

        public static void CreateOwner(Owner owner)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "INSERT INTO owners (first_name, last_name, address, phone_number, email) VALUES (@FirstName, @LastName, @Address, @PhoneNumber, @Email)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", owner.FirstName);
                command.Parameters.AddWithValue("@LastName", owner.LastName);
                command.Parameters.AddWithValue("@Address", owner.Address);
                command.Parameters.AddWithValue("@PhoneNumber", owner.PhoneNumber);
                command.Parameters.AddWithValue("@Email", owner.Email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static Owner ReadOwner(int ownerId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM owners WHERE owner_id = @OwnerId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerId", ownerId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Owner
                        {
                            OwnerId = reader.GetInt32("owner_id"),
                            FirstName = reader.GetString("first_name"),
                            LastName = reader.GetString("last_name"),
                            Address = reader.GetString("address"),
                            PhoneNumber = reader.GetString("phone_number"),
                            Email = reader.GetString("email")
                        };
                    }
                    return null;
                }
            }
        }

        public static void UpdateOwner(Owner owner)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "UPDATE owners SET first_name = @FirstName, last_name = @LastName, address = @Address, phone_number = @PhoneNumber, email = @Email WHERE owner_id = @OwnerId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerId", owner.OwnerId);
                command.Parameters.AddWithValue("@FirstName", owner.FirstName);
                command.Parameters.AddWithValue("@LastName", owner.LastName);
                command.Parameters.AddWithValue("@Address", owner.Address);
                command.Parameters.AddWithValue("@PhoneNumber", owner.PhoneNumber);
                command.Parameters.AddWithValue("@Email", owner.Email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteOwner(int ownerId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "DELETE FROM owners WHERE owner_id = @OwnerId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerId", ownerId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
		
		public static DataTable SelectAllPets()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM pets";
                var command = new MySqlCommand(query, connection);
                var dataTable = new DataTable();
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
        }

        public static DataTable SelectPetsByOwner(int ownerId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM pets WHERE owner_id = @OwnerId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerId", ownerId);
                var dataTable = new DataTable();
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
        }

        public static List<Pet> SelectPetsByOwnerList(int ownerId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM pets WHERE owner_id = @OwnerId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerId", ownerId);
                var pets = new List<Pet>();
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pets.Add(new Pet
                        {
                            PetId = reader.GetInt32("pet_id"),
                            Name = reader.GetString("name"),
                            Species = reader.GetString("species"),
                            Breed = reader.GetString("breed"),
                            BirthDate = reader.GetDateTime("birth_date"),
                            OwnerId = reader.IsDBNull(reader.GetOrdinal("owner_id")) ? (int?)null : reader.GetInt32("owner_id")
                        });
                    }
                }
                return pets;
            }
        }

        public static void CreatePet(Pet pet)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "INSERT INTO pets (name, species, breed, birth_date, owner_id) VALUES (@Name, @Species, @Breed, @BirthDate, @OwnerId)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", pet.Name);
                command.Parameters.AddWithValue("@Species", pet.Species);
                command.Parameters.AddWithValue("@Breed", pet.Breed);
                command.Parameters.AddWithValue("@BirthDate", pet.BirthDate);
                command.Parameters.AddWithValue("@OwnerId", pet.OwnerId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static Pet ReadPet(int petId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM pets WHERE pet_id = @PetId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PetId", petId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Pet
                        {
                            PetId = reader.GetInt32("pet_id"),
                            Name = reader.GetString("name"),
                            Species = reader.GetString("species"),
                            Breed = reader.GetString("breed"),
                            BirthDate = reader.GetDateTime("birth_date"),
                            OwnerId = reader.IsDBNull(reader.GetOrdinal("owner_id")) ? (int?)null : reader.GetInt32("owner_id")
                        };
                    }
                    return null;
                }
            }
        }

        public static void UpdatePet(Pet pet)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "UPDATE pets SET name = @Name, species = @Species, breed = @Breed, birth_date = @BirthDate, owner_id = @OwnerId WHERE pet_id = @PetId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PetId", pet.PetId);
                command.Parameters.AddWithValue("@Name", pet.Name);
                command.Parameters.AddWithValue("@Species", pet.Species);
                command.Parameters.AddWithValue("@Breed", pet.Breed);
                command.Parameters.AddWithValue("@BirthDate", pet.BirthDate);
                command.Parameters.AddWithValue("@OwnerId", pet.OwnerId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void DeletePet(int petId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "DELETE FROM pets WHERE pet_id = @PetId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@PetId", petId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
		
		public static DataTable SelectAllVeterinarians()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM veterinarians";
                var command = new MySqlCommand(query, connection);
                var dataTable = new DataTable();
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
        }

        public static void CreateVeterinarian(Veterinarian veterinarian)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "INSERT INTO veterinarians (first_name, last_name, specialization, phone_number, email) VALUES (@FirstName, @LastName, @Specialization, @PhoneNumber, @Email)";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", veterinarian.FirstName);
                command.Parameters.AddWithValue("@LastName", veterinarian.LastName);
                command.Parameters.AddWithValue("@Specialization", veterinarian.Specialization);
                command.Parameters.AddWithValue("@PhoneNumber", veterinarian.PhoneNumber);
                command.Parameters.AddWithValue("@Email", veterinarian.Email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static Veterinarian ReadVeterinarian(int vetId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM veterinarians WHERE vet_id = @VetId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@VetId", vetId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Veterinarian
                        {
                            VetId = reader.GetInt32("vet_id"),
                            FirstName = reader.GetString("first_name"),
                            LastName = reader.GetString("last_name"),
                            Specialization = reader.GetString("specialization"),
                            PhoneNumber = reader.GetString("phone_number"),
                            Email = reader.GetString("email")
                        };
                    }
                    return null;
                }
            }
        }

        public static void UpdateVeterinarian(Veterinarian veterinarian)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "UPDATE veterinarians SET first_name = @FirstName, last_name = @LastName, specialization = @Specialization, phone_number = @PhoneNumber, email = @Email WHERE vet_id = @VetId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@VetId", veterinarian.VetId);
                command.Parameters.AddWithValue("@FirstName", veterinarian.FirstName);
                command.Parameters.AddWithValue("@LastName", veterinarian.LastName);
                command.Parameters.AddWithValue("@Specialization", veterinarian.Specialization);
                command.Parameters.AddWithValue("@PhoneNumber", veterinarian.PhoneNumber);
                command.Parameters.AddWithValue("@Email", veterinarian.Email);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteVeterinarian(int vetId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                var query = "DELETE FROM veterinarians WHERE vet_id = @VetId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@VetId", vetId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
