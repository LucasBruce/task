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
            var taskResponse = new TaskResponse
            {
                IsCreated = true,
                Title = "Sample Task",
                Description = "This is a sample task description.",
                DueDate = DateTime.Now.AddDays(7),
                Status = {
                    Id = new Guid("d5f8c5e0-5b5b-4c5b-8c5b-5b5b5c5b5c5b"),
                    InProgress = true,
                    Completed = false,
                    Pending = false
                }
            };
            var tasks = new List<TaskResponse> { taskResponse, taskResponse, taskResponse };
            return Task.FromResult<IEnumerable<TaskResponse>>(tasks);
        }

        public Task<TaskResponse> UpdateTask(UpdatedTaskRequest updatedTaskRequest)
        {
            throw new NotImplementedException();
        }
    }
}