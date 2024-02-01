namespace YourCalendarAppServer.Models
{
    public class Appointment
    {
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Service SelectedService { get; set; }
        public string Note { get; set; }
    }
}
