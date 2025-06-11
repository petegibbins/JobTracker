using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using JobTracker.Models;

namespace JobTracker.Services
{
    public class JobService
    {
        private readonly HttpClient _http;

        public JobService(HttpClient http)
        {
            _http = http;
        }

        public virtual async Task<List<Job>> GetJobsAsync()
        {
            try
            {
                var jobs = await _http.GetFromJsonAsync<List<Job>>("sample-data/jobs.json");
                return jobs ?? new List<Job>();
            }
            catch (HttpRequestException e)
            {
                // Handle the exception (e.g., log it, rethrow it, etc.)
                throw new Exception("Error fetching jobs", e);
            }
        }
    }
}