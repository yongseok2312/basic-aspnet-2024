using System.ComponentModel.DataAnnotations;

namespace BasicWeb.Models
{
    /// <summary>
    ///  DB에 테이블로 만들어지는 엔티티 클래스
    /// </summary>
    public class Category
    {
        [Key]
        public int Id { get; set; } // PK
        [Required]
        public string Name { get; set; }
        public int DisplayOrder {  get; set; }  
        public DateTime PostDate { get; set; }  = DateTime.Now;

    }
}
