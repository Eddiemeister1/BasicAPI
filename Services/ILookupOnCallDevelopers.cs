using BasicAPI.Controllers;

namespace BasicAPI
{
    public interface ILookupOnCallDevelopers
    {
        Task<OnCallDeveloperInformation> GetOnCallDeveloperAsync();
    }
}