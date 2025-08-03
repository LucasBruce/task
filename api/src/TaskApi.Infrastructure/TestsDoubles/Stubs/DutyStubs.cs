
using TaskApi.Core.Domain.Entities;

namespace TaskApi.Infrastructure.TestsDoubles.Stubs
{
    public static class DutyStubs
    {
        public static readonly Duty Task1 = new Duty
        (
            Guid.NewGuid(),
             "Complete Project Documentation",
             "Finalize the documentation for the project and submit it for review.",
             DateTime.Now.AddDays(7),
            new Status
            (
                Pending: false,
                InProgress: true,
                Completed: false
            ),
            User: UserStubs.User1
        );
        public static readonly Duty Task2 = new Duty
        (
            Guid.NewGuid(),
            "Complete Project Documentation",
            "Finalize the documentation for the project and submit it for review.",
            DateTime.Now.AddDays(7),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User1
        );

        public static readonly Duty Task3 = new Duty
        (
            Guid.NewGuid(),
            "Complete Project Documentation",
            "Finalize the documentation for the project and submit it for review.",
            DateTime.Now.AddDays(7),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User1
        );

        public static readonly Duty Task4 = new Duty
        (
            Guid.NewGuid(),
            "Review Codebase",
            "Go through the codebase and identify areas for refactoring.",
            DateTime.Now.AddDays(3),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User2
        );

        public static readonly Duty Task5 = new Duty
        (
            Guid.NewGuid(),
            "Submit Expense Report",
            "Submit the monthly expense report to the finance department.",
            DateTime.Now.AddDays(-2),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User2
        );

        public static readonly Duty Task6 = new Duty
        (
            Guid.NewGuid(),
            "Organize Team Meeting",
            "Schedule and organize a team meeting to discuss project milestones, blockers, and next steps. Ensure all team members are available and send out calendar invites.",
            DateTime.Now.AddDays(5),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User3
        );

        public static readonly Duty Task7 = new Duty
        (
            Guid.NewGuid(),
            "Fix Bug",
            "Resolve the login issue reported by QA.",
            DateTime.Now.AddDays(1),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User4
        );

        public static readonly Duty Task8 = new Duty
        (
            Guid.NewGuid(),
            "Deploy to Production",
            "",
            DateTime.Now.AddDays(2),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User5
        );

        public static readonly Duty Task9 = new Duty
        (
            Guid.NewGuid(),
            "Plan Annual Retreat",
            "Start planning for the annual company retreat.",
            DateTime.Now.AddYears(1),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User6
        );

        public static readonly Duty Task10 = new Duty
        (
            Guid.NewGuid(),
            "",
            "This Duty has an empty title.",
            DateTime.Now.AddDays(10),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User7
        );

        public static readonly Duty Task11 = new Duty
        (
            Guid.NewGuid(),
            "Update README.md!",
            "Add badges and update the documentation in README.md.",
            DateTime.Now.AddDays(4),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User8
        );

        public static readonly Duty Task12 = new Duty
        (
            Guid.NewGuid(),
            "Daily Standup",
            "Attend the daily standup meeting.",
            DateTime.Today,
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User9
        );

        public static readonly Duty Task13 = new Duty
        (
            Guid.NewGuid(),
            "Archive Old Tasks",
            "Move completed Tasks older than 6 months to the archive.",
            DateTime.Now.AddDays(15),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User10
        );

        public static readonly Duty Task14 = new Duty
        (
            Guid.NewGuid(),
            "Conduct User Research",
            "Plan and conduct user research sessions to gather feedback on the new feature.",
            DateTime.Now.AddDays(20),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User11
        );

        public static readonly Duty Task15 = new Duty
        (
            Guid.NewGuid(),
            "Prepare Presentation",
            "Create a presentation for the upcoming stakeholder meeting.",
            DateTime.Now.AddDays(8),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User12
        );

        public static readonly Duty Task16 = new Duty
        (
            Guid.NewGuid(),
            "Conduct Code Review",
            "Review the latest pull requests and provide feedback.",
            DateTime.Now.AddDays(3),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User13
        );

        public static readonly Duty Task17 = new Duty
        (
            Guid.NewGuid(),
            "Implement Feedback",
            "Incorporate feedback from the last sprint retrospective.",
            DateTime.Now.AddDays(5),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User14
        );

        public static readonly Duty Task18 = new Duty
        (
            Guid.NewGuid(),
            "Conduct User Interviews",
            "Schedule and conduct interviews with users to gather feedback.",
            DateTime.Now.AddDays(10),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User15
        );

        public static readonly Duty Task19 = new Duty
        (
            Guid.NewGuid(),
            "Create User Personas",
            "Develop user personas based on research findings.",
            DateTime.Now.AddDays(12),
            new Status
            (
            Pending: false,
            InProgress: false,
            Completed: true
            ),
            User: UserStubs.User15
        );
    
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
                Task2,
                Task1,
                Task4
            };
        }

    }
}