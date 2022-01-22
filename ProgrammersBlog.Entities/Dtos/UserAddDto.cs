﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class UserAddDto
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        [MaxLength(50, ErrorMessage = "{0} {1} katakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} katakterden küçük olamaz.")]
        public string UserName { get; set; }

        [DisplayName("E-Posta Adresi")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        [MaxLength(100, ErrorMessage = "{0} {1} katakterden büyük olamaz.")]
        [MinLength(10, ErrorMessage = "{0} {1} katakterden küçük olamaz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        [MaxLength(100, ErrorMessage = "{0} {1} katakterden büyük olamaz.")]
        [MinLength(5, ErrorMessage = "{0} {1} katakterden küçük olamaz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz.")]
        [MaxLength(13, ErrorMessage = "{0} {1} katakterden büyük olamaz.")]
        [MinLength(13, ErrorMessage = "{0} {1} katakterden küçük olamaz.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DisplayName("Resim")]
        [Required(ErrorMessage = "Lütfen bir {0} seçiniz.")]
        [DataType(DataType.Upload)]
        public IFormFile Picture { get; set; }


    }
}
