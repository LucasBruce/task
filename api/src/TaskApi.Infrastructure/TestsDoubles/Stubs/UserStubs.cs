
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class UserStubs
    {
        public static User User1 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Alice Johnson",
            CorporateEmail = "alice.johnson@company.com",
            Job = "Software Engineer",
            Duties = new List<Duty>
            {
              DutyStubs.Task1,
              DutyStubs.Task3,
            }
        };
        public static User User2 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Bob Smith",
            CorporateEmail = "bob.smith@company.com",
            Job = "Data Analyst",
            Duties = new List<Duty>
            {
              DutyStubs.Task4,
              DutyStubs.Task5,
            }
        };

        public static User User3 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Carol Williams",
            CorporateEmail = "carol.williams@company.com",
            Job = "UX Designer",
            Duties = new List<Duty>
            {
              DutyStubs.Task6,
            }
        };

        public static User User4 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Frank Miller",
            CorporateEmail = "frank.miller@company.com",
            Job = "Product Owner",
            Duties = new List<Duty>
            {
              DutyStubs.Task7
            }
        };

        public static User User5 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Grace Lee",
            CorporateEmail = "grace.lee@company.com",
            Job = "QA Engineer",
            Duties = new List<Duty>
            {
              DutyStubs.Task8,
            }
        };

        public static User User6 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Henry Clark",
            CorporateEmail = "henry.clark@company.com",
            Job = "DevOps Engineer",
            Duties = new List<Duty>
            {
              DutyStubs.Task9,
            }
        };

        public static User User7 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Ivy Turner",
            CorporateEmail = "ivy.turner@company.com",
            Job = "Marketing Specialist",
            Duties = new List<Duty>
            {
              DutyStubs.Task10,
            }
        };

        public static User User8 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Jack White",
            CorporateEmail = "jack.white@company.com",
            Job = "Sales Executive",
            Duties = new List<Duty>
            {
              DutyStubs.Task11,
            }
        };

        public static User User9 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Karen Harris",
            CorporateEmail = "karen.harris@company.com",
            Job = "HR Manager",
            Duties = new List<Duty>
            {
              DutyStubs.Task12
            }
        };

        public static User User10 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Leo Walker",
            CorporateEmail = "leo.walker@company.com",
            Job = "Software Engineer",
            Duties = new List<Duty>
            {
              DutyStubs.Task13
            }
        };

        public static User User11 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Mona Scott",
            CorporateEmail = "mona.scott@company.com",
            Job = "Graphic Designer",
            Duties = new List<Duty>
            {
              DutyStubs.Task14
            }
        };

        public static User User12 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Nina Adams",
            CorporateEmail = "nina.adams@company.com",
            Job = "Content Writer",
            Duties = new List<Duty>
            {
              DutyStubs.Task15
            }
        };

        public static User User13 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Oscar Reed",
            CorporateEmail = "oscar.reed@company.com",
            Job = "Project Manager",
            Duties = new List<Duty>
            {
              DutyStubs.Task16
            }
        };

        public static User User14 => new User
        {
            Id = Guid.NewGuid(),
            Name = "David Brown",
            CorporateEmail = "david.brown@company.com",
            Job = "IT Support",
            Duties = new List<Duty>
            {
              DutyStubs.Task17
            }
        };

        public static User User15 => new User
        {
            Id = Guid.NewGuid(),
            Name = "Eve Davis",
            CorporateEmail = "eve.davis@company.com",
            Job = "Marketing Manager",
            Duties = new List<Duty>
            {
              DutyStubs.Task18,
              DutyStubs.Task19,
            }
        };

        public static List<User> GetAll()
        {

            return new List<User>
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