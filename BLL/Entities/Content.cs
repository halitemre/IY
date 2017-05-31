
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BLL.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Başlık 5 ile 50 karakter arasında olmalıdır!", MinimumLength = 5)]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Kısa açıklama 10 ile 250 karakter arasında olmalıdır!", MinimumLength = 10)]
        [Display(Name = "Kısa Açıklama")]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(2500, ErrorMessage = "Açıklama 10 ile 2500 karakter arasında olmalıdır!", MinimumLength = 10)]
        [Display(Name = "Açıklama")]
        public string Body { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Açıklama 5 ile 25 karakter arasında olmalıdır!", MinimumLength = 5)]
        [Display(Name = "Meta")]
        public string Meta { get; set; }

        [Required]
        [Display(Name = "UrlSeo")]
        public string UrlSeo { get; set; }


        public bool Published { get; set; }

        [DefaultValue(0)]
        public int NetLikeCount { get; set; }


        public DateTime PublishDate { get; set; }

        public DateTime? ModifyDate { get; set; }
        public bool Deleted { get;set; }
        public string LinkUrl { get; set; }



    }
}
