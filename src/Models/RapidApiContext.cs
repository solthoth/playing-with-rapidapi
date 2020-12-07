namespace playing_with_rapidapi.Models
{
    public class RapidApiContext
    {
        public virtual string Key { get; set; } = string.Empty;
        public virtual string HostTemplate { get; set; } = string.Empty;
        public virtual string WeatherByZipCode { get; set; } = string.Empty;
    }
}