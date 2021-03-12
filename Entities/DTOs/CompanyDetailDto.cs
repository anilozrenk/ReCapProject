using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class CompanyDetailDto : IDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        
    }
}
