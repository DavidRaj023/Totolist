public class ToDo
{
    private int id;
    private string title;
    private string description;
    private bool isCompleted;
    private DateTime createdAt;
    private DateTime updatedAt;

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            this.id = value;
        }
    }
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            this.title = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
        set
        {
            this.description = value;
        }
    }
    public bool IsCompleted
    {
        get
        {
            return isCompleted;
        }
        set
        {
            this.isCompleted = value;
        }
    }

    public DateTime CreatedAt
    {
        get
        {
            return createdAt;
        }
        set
        {
            this.createdAt = value;
        }
    }

    public DateTime UpdatedAt
    {
        get
        {
            return updatedAt;
        }
        set
        {
            this.updatedAt = value;
        }
    }

    private void validate(string paramValue, object field) 
    {
        if(field == null)
        {
            throw new Exception("{0} is not allowed to Null");
        }
    }
}