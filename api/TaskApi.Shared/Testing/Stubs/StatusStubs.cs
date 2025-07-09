namespace TaskApi.Shared.Testing.Stubs
{
    using TaskApi.Domain.Entities;

    // Stub class for Status entity
    public static class StatusStubs
    {
        public static readonly Status StatusStub = new Status
        {
            Completed = true,
            InProgress = false,
            Pending = false,
        };
        public static readonly Status StatusStub2 = new Status
        {
            Completed = false,
            InProgress = true,
            Pending = false,
        };

        public static readonly Status StatusStub3 = new Status
        {
            Completed = false,
            InProgress = false,
            Pending = true,
        };

        public static readonly Status StatusStub4 = new Status
        {
            Completed = true,
            InProgress = true,
            Pending = false,
        };

        public static readonly Status StatusStub5 = new Status
        {
            Completed = true,
            InProgress = false,
            Pending = true,
        };

        public static readonly Status StatusStub6 = new Status
        {
            Completed = false,
            InProgress = true,
            Pending = true,
        };

        public static readonly Status StatusStub7 = new Status
        {
            Completed = true,
            InProgress = true,
            Pending = true,
        };

        public static readonly Status StatusStub8 = new Status
        {
            Completed = false,
            InProgress = false,
            Pending = false,
        };

        public static readonly Status StatusStub9 = new Status
        {
            Completed = true,
            InProgress = false,
            Pending = false,
        };

        public static IEnumerable<Status> GetAll()
        {
            return new List<Status>
            {
            StatusStub,
            StatusStub2,
            StatusStub3,
            StatusStub4,
            StatusStub5,
            StatusStub6,
            StatusStub7,
            StatusStub8,
            StatusStub9
            };
        }
    }
}