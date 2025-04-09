public class Cat : Pet, Talkable
{
    private int mousesKilled;

    public Cat(int mousesKilled, string name)
        : base(name)
    {
        this.mousesKilled = mousesKilled;
    }

    public int MousesKilled
    {
        get { return mousesKilled; }
    }

    public void AddMouse()
    {
        mousesKilled++;
    }

    public string Talk()
    {
        return "Meow";
    }

    public override string ToString()
    {
        return $"Cat: name={name} mousesKilled={mousesKilled}";
    }
}
