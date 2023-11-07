namespace WebApplication1
{
    public class TaskModel
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Describe { get; set; }
        public DateTime Date { get; set; }
        public Preferance Preferance { get; set; }

        public TaskModel(int Id, string Title, string Describe, DateTime Date, Preferance Preferance)
        {
            this.Id = Id;
            this.Title = Title;
            this.Describe = Describe;
            this.Date = Date;
            this.Preferance = Preferance;
        }
    }
}
