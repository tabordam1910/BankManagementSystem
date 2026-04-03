namespace BankManagementSystem.Application.DTOs
{
    public class TransactionResponse
    {
        // El '=' asegura que nunca sea nulo, quitando advertencias
        public string Message { get; set; } = string.Empty; 
        
        // El '?' significa que es opcional (a veces hay saldo, a veces no)
        public decimal? Balance { get; set; } 
    }
}