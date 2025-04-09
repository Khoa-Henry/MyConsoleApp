public abstract class Pet
{
    protected string name;

    public Pet(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
    }
}
