namespace FF7;
public class Enemies
{
    //Enum to represent characters and implement turn order
    public enum EnemyTypes : int
    {
        ShinraTroop = 1,

    }

    //Create a constructor for Stats
    public Enemies(string name, int level, int healthPoints, int magicPoints, int strength, int vitality)
    {
        Name = name;
        LVL = level;
        HP = healthPoints;
        MP = magicPoints;
        ATK = strength;
        VIT = vitality;

    }

    //Use getter and setter methods to get stats and set their values
    public string Name { get; set; }
    public int LVL { get; set; }
    public int HP { get; set; }
    public int MP { get; set; }
    public int ATK { get; set; }
    public int VIT { get; set; }
}