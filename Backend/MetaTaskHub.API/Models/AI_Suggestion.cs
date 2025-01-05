namespace MetaTaskHub.API.Models
{
    public class AI_Suggestion
    {
        public int Id { get; set; }
        public string SuggestionText { get; set; } = string.Empty;
        public int TaskId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
