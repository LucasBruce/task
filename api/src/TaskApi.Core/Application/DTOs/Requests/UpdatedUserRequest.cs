using System;
using System.Collections.Generic;
using System.Linq;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class UpdatedUserRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? CorporateEmail { get; set; }
        public string? Job { get; set; }
        public List<DutyResponse>? Duties { get; set; }
    }
}