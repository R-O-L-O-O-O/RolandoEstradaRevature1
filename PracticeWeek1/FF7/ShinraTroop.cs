namespace FF7;
public class ShinraTroop : Enemies
{
    public ShinraTroop(string name, int level, int healthPoints, int magicPoints, int strength, int vitality) : base(name, level, healthPoints, magicPoints, strength, vitality)
    {
            
    }

    private static void ChracterShinraTroop()
    {
        ShinraTroop shinraTroop = new ShinraTroop("Shinra Troop", 15, 750, 50, 25, 10);
    }
}