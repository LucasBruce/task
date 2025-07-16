using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.Interfaces;

namespace TaskApi.Infrastructure.Persistence.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public Task<TaskResponse> CreateTask(CreatedTaskRequest createdTaskRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTask(FoundTaskRequest foundTaskRequest)
        {
            throw new NotImplementedException();
        }

        public Task<TaskResponse> FindTask(FoundTaskRequest foundTaskRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskResponse>> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task<TaskResponse> UpdateTask(UpdatedTaskRequest updatedTaskRequest)
        {
            throw new NotImplementedException();
        }
    }
}