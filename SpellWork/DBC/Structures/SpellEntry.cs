﻿namespace SpellWork.DBC.Structures
{
    public sealed class SpellEntry
    {
        public string Name;
        public string NameSubtext;
        public string Description;
        public string AuraDescription;
        public int MiscID;
        public int ID;
        public int DescriptionVariablesID;

        /*public List<SpellPowerEntry> SpellPowerList
        {
            get
            {
                if (DBC._spellPower.ContainsKey(Id))
                    return DBC._spellPower[Id];
                return null;
            }
        }*/
    }
}
