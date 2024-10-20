using BLL.DAL;
using BLL.Models;
using BLL.Services.Bases;

namespace BLL.Services;

public interface IStudentService
{
    public Service Create(student student);
    public Service Update(student student);
    public Service Delete(int id);
    public IQueryable<StudentModel> Query();
}

public class StudentService : Service, IStudentService
{
    public StudentService(Db db) : base(db)
    {
    }

    public Service Create(student student)
    {
        _db.students.Add(student);
        _db.SaveChanges();
        return Success();
    }

    public Service Update(student student)
    {
        _db.students.Update(student);
        _db.SaveChanges();
        return Success();
    }

    public Service Delete(int id)
    {
        var student = _db.students.Find(id);
        _db.students.Remove(student);
        _db.SaveChanges();
        return Success();
    }

    public IQueryable<StudentModel> Query()
    {
        return _db.students.OrderBy(s => s.name).Select(s => new StudentModel { Record = s });
    }
}