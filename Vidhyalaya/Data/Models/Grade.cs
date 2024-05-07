// Grade Details: Label(1,2,3 etc.), Class Teacher, Medium, Subjects, Session Year
using System.ComponentModel.DataAnnotations;

public class Grade
{
      [Key] // Specify that Label is the primary key
    public int Label {get ; set ;}
    public string ClassTeacher{get ; set ;}
    public Medium Medium {get ; set ;}
    public string Subject {get ; set ;}
    public DateTime SessionYear {get ; set ;}

}
public enum Medium
{
   English,
   Nepali
  }
