namespace AlkonostXNAGame.AlkonostDataStructure.Interfaces
{
    public  interface ICharacter
    {
        double Health { get; }
        double Damage { get; }
        double Armor { get; }
        double Movement { get; }
    }
}