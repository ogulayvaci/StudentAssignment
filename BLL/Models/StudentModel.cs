using BLL.DAL;

namespace BLL.Models;

public class StudentModel
{
    public student Record { get; set; }
    
    // public string Name => Record.name;

    public string Name => Record.name;
    public string Surname => Record.surname;
    public DateTime Birthdate => (DateTime)Record.birthdate;
    public double Gpa => (double)Record.gpa;
}