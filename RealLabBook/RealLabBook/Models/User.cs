using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace RealLabBook.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        [Required(ErrorMessage = "��سҡ�͡���ͨ�ԧ", AllowEmptyStrings = false)]
        public string name { get; set; }

        [Required(ErrorMessage = "��سҡ�͡���ʡ��", AllowEmptyStrings = false)]
        public string surname { get; set; }

        [Required(ErrorMessage = "��سҡ�͡�����", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "��������١��ͧ")]
        public string email { get; set; }

        [Required(ErrorMessage = "��سҡ�͡���ʼ�ҹ", AllowEmptyStrings = false)]
        [MinLength(8, ErrorMessage = "���ʼ�ҹ��ͧ�դ���������ҧ���� 8 �ѡ���")]
        [Number(ErrorMessage = "���ʼ�ҹ��ͧ�յ���Ţ 0-9")]
        [LowerCase(ErrorMessage = "���ʼ�ҹ��ͧ�յ���ѡ�þ������� a-z")]
        [UpperCase(ErrorMessage = "���ʼ�ҹ��ͧ�յ���ѡ�þ�����˭� A-Z")]
        public string password { get; set; }

        [Required]
        public string role { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "��س��׹�ѹ���ʼ�ҹ", AllowEmptyStrings = false)]
        [Compare("password", ErrorMessage = "���ʼ�ҹ����׹�ѹ���ç�Ѻ���ʼ�ҹ��ҧ��")]
        public string confirmPassword { get; set; }

        [Required]
        public string status { get; set; }
    }
}

public class Number : RegularExpressionAttribute
{
    public Number() : base(".*\\d+.*") { }
}

public class LowerCase : RegularExpressionAttribute
{
    public LowerCase() : base(".*[a-z]+.*") { }
}
public class UpperCase : RegularExpressionAttribute
{
    public UpperCase() : base(".*[A-Z]+.*") { }
}