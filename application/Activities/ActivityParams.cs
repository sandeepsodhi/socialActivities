namespace Application.Activities
{
    public class ActivityParams : PagingParams
    {
        public bool IsGoing { get; set; }
        public bool IsHost { get; set; }
        public DataTime StartDate { get; set; } = DateTime.UTC
        
    }
}