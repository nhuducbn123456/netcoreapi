using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcmovie.Models;

    [Table("Person")]
public class Person
{   
    [Key]
    [Required]
    public string PersonId {get;set;}
    public  string FullName {get;set;}
    public  string Address {get;set;}
}