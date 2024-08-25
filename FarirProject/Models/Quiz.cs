namespace FarirProject.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Question { get; set; }
        public string Options { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
