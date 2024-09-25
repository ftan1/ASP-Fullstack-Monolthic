namespace Domain
{
    public class Activity //Table Name
    {
        //creating properties these are the columns for the table
        public Guid Id { get; set; }//naming is important for entity framework
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}