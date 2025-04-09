public class Teacher : Person, Talkable
{
    private int age;

    public Teacher(int age, string name)
        : base(name)
    {
        this.age = age;
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Talk()
    {
        return "Don't forget to do the assigned reading!";
    }
}
