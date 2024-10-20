using BLL.DAL;
namespace BLL.Services.Bases;

public abstract class Service
{
    public bool IsSuccessful { get; set; }
    
    public String Message { get; set; } = string.Empty;

    protected readonly Db _db;

    protected Service(Db db)
    {
        _db = db;
    }

    public Service Success(string message = "")
    {
        IsSuccessful = true;
        Message = message;
        return this;
    }

    public Service Error(String message = "")
    {
        IsSuccessful = false;
        Message = message;
        return this;
    }
}