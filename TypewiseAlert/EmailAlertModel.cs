namespace TypewiseAlert
{
    public class EmailAlertModel
    {
        public string Recipient { get; set; }
        public int BreachType { get; set; }
        public string BreachName { get; set; }
        public string EmailMessage { get; set; }
    }
}
