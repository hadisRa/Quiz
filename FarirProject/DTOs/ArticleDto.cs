using FarirProject.Models;

namespace FarirProject.DTOs
{


    public class ArticleDto : Article
    {
        public List<Quiz> Quizzes { get; set; }
    }
}