using System;

namespace DesignPatterns.Script.DesignPatterns
{
    /// <summary>
    /// 背包
    /// </summary>
    public class Knapsack : ICloneable
    {
        private string _weapon;

        public string Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

        private string _armor;

        public string Armor
        {
            get => _armor;
            set => _armor = value;
        }

        public Knapsack(string weapon, string armor)
        {
            _weapon = weapon;
            _armor = armor;
        }

        public object Clone()
        {
            var clone = MemberwiseClone();
            return clone;
        }

        public override string ToString()
        {
            return "武器：" + _weapon + "  盔甲：" + _armor;
        }
    }
}