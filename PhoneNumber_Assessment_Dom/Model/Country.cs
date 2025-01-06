namespace PhoneNumber_Assessment_Dom.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string? CountryCode { get; set; }
        public string? Name { get; set; }
        public string? CountryIso { get; set; }
        public List<CountryDetail>? CountryDetails { get; set; }

    }
}
