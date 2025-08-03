
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class UserStubs
    {
        public static User User1 => new User
        (
             Guid.NewGuid(),
             "Alice Johnson",
             "alice.johnson@company.com",
             "Software Engineer",
             [
               DutyStubs.Task1,
               DutyStubs.Task2,
               DutyStubs.Task3,
            ]
        );

        public static User User2 => new User
        (
             Guid.NewGuid(),
             "Bob Smith",
             "bob.smith@company.com",
             "Data Analyst",
             [
                DutyStubs.Task4,
                DutyStubs.Task5,
            ]
        );

        public static User User3 => new User
        (
             Guid.NewGuid(),
             "Carol Williams",
             "carol.williams@company.com",
             "UX Designer",
             [
                DutyStubs.Task6,
            ]
        );

        public static User User4 => new User
        (
             Guid.NewGuid(),
             "Frank Miller",
             "frank.miller@company.com",
             "Product Owner",
             [
                DutyStubs.Task7
            ]
        );

        public static User User5 => new User
        (
            Guid.NewGuid(),
            "Grace Lee",
            "grace.lee@company.com",
            "QA Engineer",
            [
                DutyStubs.Task8,
            ]
        );

        public static User User6 => new User
        (
            Guid.NewGuid(),
            "Henry Clark",
            "henry.clark@company.com",
            "DevOps Engineer",
            [
                DutyStubs.Task9,
            ]
        );

        public static User User7 => new User
        (
            Guid.NewGuid(),
            "Ivy Turner",
            "ivy.turner@company.com",
            "Marketing Specialist",
            [
                DutyStubs.Task10,
            ]
        );

        public static User User8 => new User
        (
            Guid.NewGuid(),
            "Jack White",
            "jack.white@company.com",
            "Sales Executive",
            [
                DutyStubs.Task11,
            ]
        );

        public static User User9 => new User
        (
            Guid.NewGuid(),
            "Karen Harris",
             "karen.harris@company.com",
             "HR Manager",
             [
                DutyStubs.Task12
            ]
        );

        public static User User10 => new User
        (
            Guid.NewGuid(),
            "Leo Walker",
            "leo.walker@company.com",
            "Software Engineer",
            [
                DutyStubs.Task13
            ]
        );

        public static User User11 => new User
        (
            Guid.NewGuid(),
            "Mona Scott",
            "mona.scott@company.com",
            "Graphic Designer",
             [
                DutyStubs.Task14
            ]
        );

        public static User User12 => new User
        (
            Guid.NewGuid(),
            "Nina Adams",
            "nina.adams@company.com",
            "Content Writer",
            [
                DutyStubs.Task15
            ]
        );

        public static User User13 => new User
        (
            Guid.NewGuid(),
            "Oscar Reed",
            "oscar.reed@company.com",
            "Project Manager",
             [
                DutyStubs.Task16
             ]
        );

        public static User User14 => new User
        (
            Guid.NewGuid(),
            "David Brown",
            "david.brown@company.com",
            "IT Support",
             [
                DutyStubs.Task17
            ]
        );

        public static User User15 => new User
        (
            Guid.NewGuid(),
            "Eve Davis",
            "eve.davis@company.com",
            "Marketing Manager",
            [
                DutyStubs.Task18,
                DutyStubs.Task19,
            ]
        );

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