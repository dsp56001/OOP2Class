namespace DIDemo
{
    public interface IWeapon
    {
        string Name { get; set;  }
        string Hit(string target);
    }
}