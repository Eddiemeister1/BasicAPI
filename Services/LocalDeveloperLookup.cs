using BasicAPI.Controllers;

namespace BasicAPI.Services
{
    public class LocalDeveloperLookup : ILookupOnCallDevelopers
    {
        public async Task<OnCallDeveloperInformation> GetOnCallDeveloperAsync()
        {
            await Task.Delay(3000);
            return new OnCallDeveloperInformation { OnCallDeveloperEmail = "Rob@aol.com", OnCallDeveloperName = "Robert Smith" };
        }

    }
}
