using Bunit;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using JobTracker.Services;
using JobTracker.Models;
using JobTracker.Pages;

namespace JobTracker.Tests;
public class JobListTests : TestContext
{
    [Fact]
    public void JobList_DisplaysAllJobs()
    {
        // Arrange
        var fakeJobs = new List<Job>
        {
            new Job { Title = "Developer", Company = "ABC Ltd" },
            new Job { Title = "Tester", Company = "XYZ Ltd" }
        };

        Services.AddSingleton<JobService>(new FakeJobService(fakeJobs));

        // Act
        var cut = RenderComponent<Joblist>();

        // Assert
        cut.MarkupMatches(@"
            <h3>Job List</h3>
            <ul>
              <li>Developer - ABC Ltd</li>
              <li>Tester - XYZ Ltd</li>
            </ul>
        ");
    }

    public class FakeJobService : JobService
    {
        private readonly List<Job> _jobs;

        public FakeJobService(List<Job> jobs) : base(null!)
        {
            _jobs = jobs;
        }

        public override Task<List<Job>> GetJobsAsync() => Task.FromResult(_jobs);
    }
}