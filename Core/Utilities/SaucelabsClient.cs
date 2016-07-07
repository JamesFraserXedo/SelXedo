using Core.StepsSupport;

namespace Core.Utilities
{
    public class SaucelabsClient
    {
        private string _username;
        private string _accessKey;
        private string _jobId;

        public SaucelabsClient(string jobId)
        {
            _username = TestsConfig.SaucelabsUsername;
            _accessKey = TestsConfig.SaucelabsAccessKey;
            _jobId = jobId;
        }
    }
}
