using System.ComponentModel.DataAnnotations;

namespace FarirProject.Models
{
    public class Quiz
    {
        [Display(Name = "تاریخ انتشار")]
        public int Id { get; set; }
        [Display(Name = "شماره ی مقاله")]
        public int ArticleId { get; set; }
        [Display(Name = "سوال")]
        public string Question { get; set; }
        [Display(Name = "گزینه‌ها")]
        public string Options { get; set; }
        [Display(Name = "پاسخ صحیح")]
        public string CorrectAnswer { get; set; }
    }
}
