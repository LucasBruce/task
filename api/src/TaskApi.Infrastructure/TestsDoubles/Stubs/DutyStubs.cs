
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
            Owner = new Owner
            {
                Id = UserStubs.User1.Id,
                Name = UserStubs.User1.Name,
                CorporateEmail = UserStubs.User1.CorporateEmail,
                Job = UserStubs.User1.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User1.Id,
                Name = UserStubs.User1.Name,
                CorporateEmail = UserStubs.User1.CorporateEmail,
                Job = UserStubs.User1.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User2.Id,
                Name = UserStubs.User2.Name,
                CorporateEmail = UserStubs.User2.CorporateEmail,
                Job = UserStubs.User2.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User2.Id,
                Name = UserStubs.User2.Name,
                CorporateEmail = UserStubs.User2.CorporateEmail,
                Job = UserStubs.User2.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User3.Id,
                Name = UserStubs.User3.Name,
                CorporateEmail = UserStubs.User3.CorporateEmail,
                Job = UserStubs.User3.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User4.Id,
                Name = UserStubs.User4.Name,
                CorporateEmail = UserStubs.User4.CorporateEmail,
                Job = UserStubs.User4.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User5.Id,
                Name = UserStubs.User5.Name,
                CorporateEmail = UserStubs.User5.CorporateEmail,
                Job = UserStubs.User5.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User6.Id,
                Name = UserStubs.User6.Name,
                CorporateEmail = UserStubs.User6.CorporateEmail,
                Job = UserStubs.User6.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User7.Id,
                Name = UserStubs.User7.Name,
                CorporateEmail = UserStubs.User7.CorporateEmail,
                Job = UserStubs.User7.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User8.Id,
                Name = UserStubs.User8.Name,
                CorporateEmail = UserStubs.User8.CorporateEmail,
                Job = UserStubs.User8.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User9.Id,
                Name = UserStubs.User9.Name,
                CorporateEmail = UserStubs.User9.CorporateEmail,
                Job = UserStubs.User9.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User10.Id,
                Name = UserStubs.User10.Name,
                CorporateEmail = UserStubs.User10.CorporateEmail,
                Job = UserStubs.User10.Job
            }
        };

        public static readonly Duty Task14 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Conduct Owner Research",
            Description = "Plan and conduct user research sessions to gather feedback on the new feature.",
            DueDate = DateTime.Now.AddDays(20),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            Owner = new Owner
            {
                Id = UserStubs.User11.Id,
                Name = UserStubs.User11.Name,
                CorporateEmail = UserStubs.User11.CorporateEmail,
                Job = UserStubs.User11.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User12.Id,
                Name = UserStubs.User12.Name,
                CorporateEmail = UserStubs.User12.CorporateEmail,
                Job = UserStubs.User12.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User13.Id,
                Name = UserStubs.User13.Name,
                CorporateEmail = UserStubs.User13.CorporateEmail,
                Job = UserStubs.User13.Job
            }
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
            Owner = new Owner
            {
                Id = UserStubs.User14.Id,
                Name = UserStubs.User14.Name,
                CorporateEmail = UserStubs.User14.CorporateEmail,
                Job = UserStubs.User14.Job
            }
        };

        public static readonly Duty Task18 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Conduct Owner Interviews",
            Description = "Schedule and conduct interviews with users to gather feedback.",
            DueDate = DateTime.Now.AddDays(10),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            Owner = new Owner
            {
                Id = UserStubs.User15.Id,
                Name = UserStubs.User15.Name,
                CorporateEmail = UserStubs.User15.CorporateEmail,
                Job = UserStubs.User15.Job
            }
        };

        public static readonly Duty Task19 = new Duty
        {
            Id = Guid.NewGuid(),
            Title = "Create Owner Personas",
            Description = "Develop user personas based on research findings.",
            DueDate = DateTime.Now.AddDays(12),
            Status = new Status
            {
                Pending = false,
                InProgress = false,
                Completed = true
            },
            Owner = new Owner
            {
                Id = UserStubs.User15.Id,
                Name = UserStubs.User15.Name,
                CorporateEmail = UserStubs.User15.CorporateEmail,
                Job = UserStubs.User15.Job
            }
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