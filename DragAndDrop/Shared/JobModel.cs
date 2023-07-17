namespace DragAndDrop.Shared
{
    public class JobModel
    {
        public int Id { get; set; }
        public JobStatuses Status { get; set; }
        public string Description { get; set; } = null!;
        public DateTime LastUpdated { get; set; }
    }

    public enum JobStatuses
    {
        Todo,
        Started,
        Completed
    }
}
