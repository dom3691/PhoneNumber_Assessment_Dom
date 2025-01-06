namespace PhoneNumber_Assessment_Dom.Model
{
    public class CountryDetail
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
        public Country Country { get; set; }
    }
}
