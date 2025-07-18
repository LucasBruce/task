
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
            Duties = [
               DutyStubs.Task1,
               DutyStubs.Task2,
               DutyStubs.Task3,
            ]
        };

        public static UserResponse User2 => new UserResponse
        {
            IsCreated = true,
            Name = "Bob Smith",
            CorporateEmail = "bob.smith@company.com",
            Job = "Data Analyst",
            Duties = [
                DutyStubs.Task4,
                DutyStubs.Task5,
            ]
        };

        public static UserResponse User3 => new UserResponse
        {
            IsCreated = true,
            Name = "Carol Williams",
            CorporateEmail = "carol.williams@company.com",
            Job = "UX Designer",
            Duties = [
                DutyStubs.Task4,
            ]
        };

        public static UserResponse User4 => new UserResponse
        {
            IsCreated = true,
            Name = "Frank Miller",
            CorporateEmail = "frank.miller@company.com",
            Job = "Product Owner",
            Duties = [
                DutyStubs.Task9
            ]
        };

        public static UserResponse User5 => new UserResponse
        {
            IsCreated = true,
            Name = "Grace Lee",
            CorporateEmail = "grace.lee@company.com",
            Job = "QA Engineer",
            Duties = [
                DutyStubs.Task6,
            ]
        };

        public static UserResponse User6 => new UserResponse
        {
            IsCreated = true,
            Name = "Henry Clark",
            CorporateEmail = "henry.clark@company.com",
            Job = "DevOps Engineer",
            Duties = [
                DutyStubs.Task7,
                DutyStubs.Task8,
            ]
        };

        public static UserResponse User7 => new UserResponse
        {
            IsCreated = true,
            Name = "Ivy Turner",
            CorporateEmail = "ivy.turner@company.com",
            Job = "Marketing Specialist",
            Duties = [
                DutyStubs.Task6,
            ]
        };

        public static UserResponse User8 => new UserResponse
        {
            IsCreated = true,
            Name = "Jack White",
            CorporateEmail = "jack.white@company.com",
            Job = "Sales Executive",
            Duties = [
                DutyStubs.Task8,
            ]
        };

        public static UserResponse User9 => new UserResponse
        {
            IsCreated = true,
            Name = "Karen Harris",
            CorporateEmail = "karen.harris@company.com",
            Job = "HR Manager",
            Duties = [
                DutyStubs.Task8
            ]
        };

        public static UserResponse User10 => new UserResponse
        {
            IsCreated = true,
            Name = "Leo Walker",
            CorporateEmail = "leo.walker@company.com",
            Job = "Software Engineer",
            Duties = [
                DutyStubs.Task3
            ]
        };

        public static UserResponse User11 => new UserResponse
        {
            IsCreated = true,
            Name = "Mona Scott",
            CorporateEmail = "mona.scott@company.com",
            Job = "Graphic Designer",
            Duties = [
                DutyStubs.Task4
            ]
        };

        public static UserResponse User12 => new UserResponse
        {
            IsCreated = true,
            Name = "Nina Adams",
            CorporateEmail = "nina.adams@company.com",
            Job = "Content Writer",
            Duties = [
                DutyStubs.Task5
            ]
        };

        public static UserResponse User13 => new UserResponse
        {
            IsCreated = true,
            Name = "Oscar Reed",
            CorporateEmail = "oscar.reed@company.com",
            Job = "Project Manager",
            Duties = [
                DutyStubs.Task6
            ]
        };

        public static UserResponse User14 => new UserResponse
        {
            IsCreated = true,
            Name = "David Brown",
            CorporateEmail = "david.brown@company.com",
            Job = "IT Support",
            Duties = [
                DutyStubs.Task7
            ]
        };

        public static UserResponse User15 => new UserResponse
        {
            IsCreated = true,
            Name = "Eve Davis",
            CorporateEmail = "eve.davis@company.com",
            Job = "Marketing Manager",
            Duties = [
                DutyStubs.Task1,
                DutyStubs.Task2,
            ]
        };

        public static List<UserResponse> GetAll()
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