using Microsoft.AspNetCore.Http;
using OrderManagement.Domain.Models;

namespace OrderManagement.API.Controllers
{
    public class OrderParameter
    {
        public int Id { get; set; }
        
        public IFormFile file { get; set; }
    }
}