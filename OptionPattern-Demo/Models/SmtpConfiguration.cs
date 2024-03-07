namespace OptionPattern_Demo.Models
{
    public record class SmtpConfiguration
    {
        public string Domain { get; init; }
        public int Port { get; init; }
    }
}
