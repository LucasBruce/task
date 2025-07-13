using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class UpdatedUserRequest
    {
        public string? Name { get; set; } = "";
        public string? CorporateEmail { get; set; } = "";
        public string? Job { get; set; } = "";
        public List<Task>? Tasks { get; set; } = new List<Task>();
    }
}