using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskApi.Core.Application.DTOs.Requests;
using TaskApi.Core.Application.DTOs.Responses;
using TaskApi.Core.Application.Interfaces;

namespace TaskApi.Core.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public Task<TaskResponse> CreateTask(CreatedTaskRequest createdTaskRequest)
        {
            var taskResponse = this.taskRepository.CreateTask(createdTaskRequest);

            return taskResponse;
        }

        public Task<bool> DeleteTask(FoundTaskRequest foundTaskRequest)
        {
            var isDeleted = this.taskRepository.DeleteTask(foundTaskRequest);

            return isDeleted;
        }

        public Task<TaskResponse> FindTask(FoundTaskRequest foundTaskRequest)
        {
            var taskResponse = this.taskRepository.FindTask(foundTaskRequest);

            return taskResponse;
        }

        public Task<IEnumerable<TaskResponse>> GetAllTasks()
        {
            var tasks = this.taskRepository.GetAllTasks();

            return tasks;
        }

        public Task<TaskResponse> UpdateTask(UpdatedTaskRequest updatedTaskRequest)
        {
            var taskResponse = this.taskRepository.UpdateTask(updatedTaskRequest);

            return taskResponse;
        }
    }
}