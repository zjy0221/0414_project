using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410919954.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }

    public class StudentMetadata
    {
        public int Id { get; set; }
        //
        //
        [Required(ErrorMessage = "請填寫姓名")]
        [Display(Name = "姓名")]
        [MinLength(2, ErrorMessage = "請輸入2 - 5個字")]
        [MaxLength(5, ErrorMessage = "請輸入2 - 5個字")]
        public string UserName { get; set; }
        //
        //
        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength (10,  MinimumLength =1 ,  ErrorMessage = "請輸入1 - 10個字")]
        public string Number { get; set; }
        //
        //
        [Required(ErrorMessage = "請填寫 E-mail")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        //
        //

        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "是否註冊")]
        public bool IsActive { get; set; }

    }




}