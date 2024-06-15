namespace dotnet_rpg.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "Frodo";
    public int HitPoint { get; set; } = 100;
    public int Strength { get; set; } = 10;
    public int Defense { get; set; } = 10;
    public int Intelligence { get; set; } = 10;
    public RpgClass Class { get; set; } = RpgClass.Knight;

    public Character(int id, string name, int hitPoint, int strength, int defense, int intelligence, RpgClass @class)
    {
        Id = id;
        Name = name;
        HitPoint = hitPoint;
        Strength = strength;
        Defense = defense;
        Intelligence = intelligence;
        Class = @class;
    }
}