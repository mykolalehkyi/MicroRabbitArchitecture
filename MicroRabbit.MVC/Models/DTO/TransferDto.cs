using System.ComponentModel.DataAnnotations.Schema;

namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDto
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
