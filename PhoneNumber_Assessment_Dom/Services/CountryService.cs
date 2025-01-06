namespace PhoneNumberAssessment.Services
{
    public class CountryService
    {
        private readonly ApplicationDbContext _context;

        public CountryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public object GetCountryByPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 3)
                return null;

            // Extract country code dynamically
            var country = _context.Countries
                .FirstOrDefault(c => phoneNumber.StartsWith(c.CountryCode));

            if (country == null)
                return null;

            var countryDetails = _context.CountryDetails
                .Where(cd => cd.CountryId == country.Id)
                .Select(cd => new
                {
                    cd.Operator,
                    cd.OperatorCode
                }).ToList();

            return new
            {
                number = phoneNumber,
                country = new
                {
                    country.CountryCode,
                    country.Name,
                    country.CountryIso,
                    countryDetails
                }
            };
        }
    }
}
