using System.ComponentModel.DataAnnotations;
class Student
{
    [Required]
    [EmailValidatorAtrribute]
    public string Email{get;set;}
}