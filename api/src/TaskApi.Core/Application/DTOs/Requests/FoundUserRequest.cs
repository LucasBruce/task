using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class FoundUserRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = "";
        public string? CorporateEmail { get; set; } = "";
    }
}