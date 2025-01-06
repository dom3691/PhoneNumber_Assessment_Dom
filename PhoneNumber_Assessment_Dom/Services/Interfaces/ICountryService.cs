namespace PhoneNumber_Assessment_Dom.Services.Interfaces
{
    public interface ICountryService
    {
        object GetCountryByPhoneNumber(string phoneNumber);
    }
}
