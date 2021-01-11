using System;

namespace MyClassLib
{
    public class Tank
    {
        private string _tankName;
        private int _ammunitionLevel;
        private int _armorLevel;
        private int _levelOfAgility;
        public Tank() { }                   
        public Tank(string tankName, int ammunitionLevel, int armorLevel,int levelOfAgility)
        {
            _tankName = tankName;
            _ammunitionLevel = ammunitionLevel; 
            _armorLevel = armorLevel;           
            _levelOfAgility = levelOfAgility;   
        }
        public string GetTankName()
        {
            return _tankName;
        }
        public string GetAmmunitionLevel()
        {
            return string.Concat( _ammunitionLevel);
        }
        public string GetArmorLevel()
        {
            return string.Concat(_armorLevel);
        }
        public string GetLevelOfAgility()
        {
            return string.Concat(_levelOfAgility);
        }

        public static Tank operator *(Tank tankT34, Tank tankPantera)
        {
            if(tankT34._ammunitionLevel > tankPantera._ammunitionLevel && tankT34._armorLevel > tankPantera._armorLevel)
            {
                return tankT34;
            }
            if(tankT34._ammunitionLevel > tankPantera._ammunitionLevel && tankT34._levelOfAgility > tankPantera._levelOfAgility)
            {
                return tankT34;
            }
            if(tankT34._armorLevel > tankPantera._armorLevel && tankT34._levelOfAgility > tankPantera._levelOfAgility)
            {
                return tankT34;
            }
            else
            {
                return tankPantera;
            }
        }


    }
}
