using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;

namespace TaskApi.Core.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskResponse>> GetAllTasks();
        Task<TaskResponse> CreateTask(CreatedTaskRequest createdTaskRequest);
        Task<TaskResponse> UpdateTask(UpdatedTaskRequest updatedTaskRequest);
        Task<TaskResponse> FindTask(FoundTaskRequest foundTaskRequest);
        Task<bool> DeleteTask(FoundTaskRequest foundTaskRequest);
    }
}