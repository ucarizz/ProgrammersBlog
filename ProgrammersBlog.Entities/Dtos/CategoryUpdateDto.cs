using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        [MaxLength(70, ErrorMessage = "{0} [1} katakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} [1} katakterden az olamaz.")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        [MaxLength(500, ErrorMessage = "{0} [1} katakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} [1} katakterden az olamaz.")]
        public string Description { get; set; }

        [DisplayName("Kategori Özel Not Alanı")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        [MaxLength(70, ErrorMessage = "{0} [1} katakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} [1} katakterden az olamaz.")]
        public string Note { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        public bool IsActive { get; set; }

        [DisplayName("Silindi Mi?")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        public bool IsDeleted { get; set; }

    }
}
