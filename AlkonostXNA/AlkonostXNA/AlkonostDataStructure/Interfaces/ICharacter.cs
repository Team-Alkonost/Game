namespace AlkonostXNAGame.AlkonostDataStructure.Interfaces
{
    public  interface ICharacter
    {
        float HealthPoints { get; }
        float AttackPoints { get; }
        float ArmorPoints { get; }
        float MovementSpeed { get; }
    }
}