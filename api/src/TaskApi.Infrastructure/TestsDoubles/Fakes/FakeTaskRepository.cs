using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.Interfaces;
using TaskApi.Infrastructure.TestsDoubles.Stubs;

namespace TaskApi.Infrastructure.TestsDoubles.Fakes
{
    public class FakeTaskRepository : ITaskRepository
    {
        public Task<TaskResponse> CreateTask(CreatedTaskRequest createdTaskRequest)
        {
            var taskResponse = new TaskResponse
            {
                IsCreated = true,
                Title = createdTaskRequest.Title,
                Description = createdTaskRequest.Description,
                DueDate = createdTaskRequest.DueDate,
                Status = createdTaskRequest.Status,
            };

            return Task.FromResult(taskResponse);
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