
using TaskApi.Core.Application.DTOs.Responses;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class UserResponseStubs
    {
        public static UserResponse User1 => new UserResponse
        {
            IsCreated = true,
            Name = "Alice Johnson",
            CorporateEmail = "alice.johnson@company.com",
            Job = "Software Engineer",
            Tasks = [
               TaskStubs.Task1,
               TaskStubs.Task2,
               TaskStubs.Task3,
            ]
        };

        public static UserResponse User2 => new UserResponse
        {
            IsCreated = true,
            Name = "Bob Smith",
            CorporateEmail = "bob.smith@company.com",
            Job = "Data Analyst",
            Tasks = [
                TaskStubs.Task4,
                TaskStubs.Task5,
            ]
        };

        public static UserResponse User3 => new UserResponse
        {
            IsCreated = true,
            Name = "Carol Williams",
            CorporateEmail = "carol.williams@company.com",
            Job = "UX Designer",
            Tasks = [
                TaskStubs.Task4,
            ]
        };

        public static UserResponse User4 => new UserResponse
        {
            IsCreated = true,
            Name = "Frank Miller",
            CorporateEmail = "frank.miller@company.com",
            Job = "Product Owner",
            Tasks = [
                TaskStubs.Task9
            ]
        };

        public static UserResponse User5 => new UserResponse
        {
            IsCreated = true,
            Name = "Grace Lee",
            CorporateEmail = "grace.lee@company.com",
            Job = "QA Engineer",
            Tasks = [
                TaskStubs.Task6,
            ]
        };

        public static UserResponse User6 => new UserResponse
        {
            IsCreated = true,
            Name = "Henry Clark",
            CorporateEmail = "henry.clark@company.com",
            Job = "DevOps Engineer",
            Tasks = [
                TaskStubs.Task7,
                TaskStubs.Task8,
            ]
        };

        public static UserResponse User7 => new UserResponse
        {
            IsCreated = true,
            Name = "Ivy Turner",
            CorporateEmail = "ivy.turner@company.com",
            Job = "Marketing Specialist",
            Tasks = [
                TaskStubs.Task6,
            ]
        };

        public static UserResponse User8 => new UserResponse
        {
            IsCreated = true,
            Name = "Jack White",
            CorporateEmail = "jack.white@company.com",
            Job = "Sales Executive",
            Tasks = [
                TaskStubs.Task8,
            ]
        };

        public static UserResponse User9 => new UserResponse
        {
            IsCreated = true,
            Name = "Karen Harris",
            CorporateEmail = "karen.harris@company.com",
            Job = "HR Manager",
            Tasks = [
                TaskStubs.Task8
            ]
        };

        public static UserResponse User10 => new UserResponse
        {
            IsCreated = true,
            Name = "Leo Walker",
            CorporateEmail = "leo.walker@company.com",
            Job = "Software Engineer",
            Tasks = [
                TaskStubs.Task3
            ]
        };

        public static UserResponse User11 => new UserResponse
        {
            IsCreated = true,
            Name = "Mona Scott",
            CorporateEmail = "mona.scott@company.com",
            Job = "Graphic Designer",
            Tasks = [
                TaskStubs.Task4
            ]
        };

        public static UserResponse User12 => new UserResponse
        {
            IsCreated = true,
            Name = "Nina Adams",
            CorporateEmail = "nina.adams@company.com",
            Job = "Content Writer",
            Tasks = [
                TaskStubs.Task5
            ]
        };

        public static UserResponse User13 => new UserResponse
        {
            IsCreated = true,
            Name = "Oscar Reed",
            CorporateEmail = "oscar.reed@company.com",
            Job = "Project Manager",
            Tasks = [
                TaskStubs.Task6
            ]
        };

        public static UserResponse User14 => new UserResponse
        {
            IsCreated = true,
            Name = "David Brown",
            CorporateEmail = "david.brown@company.com",
            Job = "IT Support",
            Tasks = [
                TaskStubs.Task7
            ]
        };

        public static UserResponse User15 => new UserResponse
        {
            IsCreated = true,
            Name = "Eve Davis",
            CorporateEmail = "eve.davis@company.com",
            Job = "Marketing Manager",
            Tasks = [
                TaskStubs.Task1,
                TaskStubs.Task2,
            ]
        };

        public static IEnumerable<UserResponse> GetAll()
        {

            return new List<UserResponse>
            {
                User1,
                User2,
                User3,
                User4,
                User5,
                User6,
                User7,
                User8,
                User9,
                User10,
                User11,
                User12,
                User13,
                User14,
                User15
            };
        }
    }
}