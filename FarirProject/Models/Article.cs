using System.ComponentModel.DataAnnotations;

namespace FarirProject.Models
{

    public class Article
    {

        [Display(Name = "شماره ی یکتا")]
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        public string? Title { get; set; }
        [Display(Name = "محتوا")]
        public string? Content { get; set; }
        [Display(Name = "نویسنده")]
        public string? Author { get; set; }
        [Display(Name = "تاریخ انتشار")]
        public DateTime PublishedDate { get; set; }
    }
}

