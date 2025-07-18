using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class FoundDutyRequest
    {
        public Guid Id { get; set; }
        public string? Title { get; set; } = "";
        public string? Description { get; set; } = "";
    }
}