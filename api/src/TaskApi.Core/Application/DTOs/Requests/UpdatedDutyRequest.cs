using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Core.Application.DTOs.Requests
{
    public class UpdatedDutyRequest
    {
        public string? Title { get; set; } = "";
        public string? Description { get; set; } = "";
        public DateTime? DueDate { get; set; } = DateTime.Now;
        public Status? Status { get; set; } = new Status();
    }
}