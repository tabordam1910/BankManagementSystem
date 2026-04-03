using System;

namespace BankManagementSystem.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }                   // Identificador único
        public required string FullName { get; set; }  // Nombre completo obligatorio
        public string? Email { get; set; }             // Ejemplo de propiedad opcional
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Fecha de creación por defecto

        // Constructor vacío (necesario para serialización y EF)
        public User() { }

        // Constructor opcional para inicializar propiedades requeridas
        public User(Guid id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }
    }
}