namespace BodySim
{
    class CreatureGen
    {
        private static string name, color, creature;

        public static string CreatureBase(string creatureName, string creatureColor)
        {
            name = creatureName;
            color = creatureColor;
            creature = creatureColor + creatureName;
            return creature;
        }
    }
}