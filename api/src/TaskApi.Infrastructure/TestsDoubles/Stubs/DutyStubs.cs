
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class DutyStubs
    {
        public static readonly Duty Task1 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = new Status
            {
                Pending = false,
                InProgress = true,
                Completed = false
            },
            User = UserStubs.User1
        };
        public static readonly Duty Task3 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Complete Project Documentation",
            Description = "Finalize the documentation for the project and submit it for review.",
            DueDate = DateTime.Now.AddDays(7),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User1
        };

        public static readonly Duty Task4 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Review Codebase",
            Description = "Go through the codebase and identify areas for refactoring.",
            DueDate = DateTime.Now.AddDays(3),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User2
        };

        public static readonly Duty Task5 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Submit Expense Report",
            Description = "Submit the monthly expense report to the finance department.",
            DueDate = DateTime.Now.AddDays(-2),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User2
        };

        public static readonly Duty Task6 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Organize Team Meeting",
            Description = "Schedule and organize a team meeting to discuss project milestones, blockers, and next steps. Ensure all team members are available and send out calendar invites.",
            DueDate = DateTime.Now.AddDays(5),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User3
        };

        public static readonly Duty Task7 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Fix Bug",
            Description = "Resolve the login issue reported by QA.",
            DueDate = DateTime.Now.AddDays(1),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User4
        };

        public static readonly Duty Task8 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Deploy to Production",
            Description = "",
            DueDate = DateTime.Now.AddDays(2),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User5
        };

        public static readonly Duty Task9 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Plan Annual Retreat",
            Description = "Start planning for the annual company retreat.",
            DueDate = DateTime.Now.AddYears(1),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User6
        };

        public static readonly Duty Task10 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "",
            Description = "This Duty has an empty title.",
            DueDate = DateTime.Now.AddDays(10),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User7
        };

        public static readonly Duty Task11 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Update README.md!",
            Description = "Add badges and update the documentation in README.md.",
            DueDate = DateTime.Now.AddDays(4),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User8
        };

        public static readonly Duty Task12 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Daily Standup",
            Description = "Attend the daily standup meeting.",
            DueDate = DateTime.Today,
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User9
        };

        public static readonly Duty Task13 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Archive Old Tasks",
            Description = "Move completed Tasks older than 6 months to the archive.",
            DueDate = DateTime.Now.AddDays(15),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User10
        };

        public static readonly Duty Task14 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Conduct User Research",
            Description = "Plan and conduct user research sessions to gather feedback on the new feature.",
            DueDate = DateTime.Now.AddDays(20),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User11
        };

        public static readonly Duty Task15 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Prepare Presentation",
            Description = "Create a presentation for the upcoming stakeholder meeting.",
            DueDate = DateTime.Now.AddDays(8),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User12
        };

        public static readonly Duty Task16 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Conduct Code Review",
            Description = "Review the latest pull requests and provide feedback.",
            DueDate = DateTime.Now.AddDays(3),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User13
        };

        public static readonly Duty Task17 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Implement Feedback",
            Description = "Incorporate feedback from the last sprint retrospective.",
            DueDate = DateTime.Now.AddDays(5),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User14
        };

        public static readonly Duty Task18 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Conduct User Interviews",
            Description = "Schedule and conduct interviews with users to gather feedback.",
            DueDate = DateTime.Now.AddDays(10),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User15
        };

        public static readonly Duty Task19 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Create User Personas",
            Description = "Develop user personas based on research findings.",
            DueDate = DateTime.Now.AddDays(12),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            User = UserStubs.User15
        };
      
    
        public static List<Duty> GetAll()
        {
            return new List<Duty>
            {
                Task19,
                Task18,
                Task17,
                Task16,
                Task15,
                Task14,
                Task13,
                Task12,
                Task11,
                Task10,
                Task9,
                Task8,
                Task7,
                Task6,
                Task5,
                Task3,
                Task1,
                Task4
            };
        }

    }
}