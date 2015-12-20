namespace AlkonostXNAGame.AlkonostDataStructure.Interfaces
{
    public  interface ICharacter
    {
        int HealthPoints { get; }
        float AttackPoints { get; }
        float ArmorPoints { get; }
        float MovementSpeed { get; }
    }
}