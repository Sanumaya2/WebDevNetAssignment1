// Student Details: Name, Address, Gender, Dob, Photo, Guardian Details
using System.ComponentModel.DataAnnotations;

public class Student
{
    public int Id{get ; set ;}
  public string Name { get; set; }
    public string Address { get; set; }
    public string Gender{get ; set;}
    public DateTime Dob { get; set; }
   public string? Photo {get ; set ;}
   public bool IsActive {get; set ;}
    


}




