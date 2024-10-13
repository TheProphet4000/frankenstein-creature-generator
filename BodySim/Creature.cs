namespace BodySim
{
    class Creature
    {
        private static string name, color, head, arms, torso, legs, tail, hands, feet, creature ;

        public static string CreatureBase(string creatureName, string creatureColor, string creatureHead, string creatureArms, string creatureTorso, string creatureLegs, string creatureTail, string creatureHands, string creatureFeet)
        {
            name = creatureName;
            color = creatureColor;
            head = creatureHead;
            arms = creatureArms;
            torso = creatureTorso;
            legs =  creatureLegs;
            tail = creatureTail;
            hands = creatureHands;
            feet = creatureFeet;

            creature = name + color + head + arms + torso + legs + tail + hands + feet;
            return creature;
        }
    }
}