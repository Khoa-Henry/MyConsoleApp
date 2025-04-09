public class Dog : Pet, Talkable
{
    private bool friendly;

    public Dog(bool friendly, string name)
        : base(name)
    {
        this.friendly = friendly;
    }

    public bool IsFriendly
    {
        get { return friendly; }
    }

    public string Talk()
    {
        return "Bark";
    }

    public override string ToString()
    {
        return $"Dog: name={name} friendly={friendly}";
    }
}
