using FarirProject.Models;

namespace FarirProject.DTOs
{

    public class QuizDto : Quiz
    {
        public bool IsCorrect { get; set; }
    }
}