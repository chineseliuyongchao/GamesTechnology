using System;

namespace DesignPatterns.Script.PrototypePattern
{
    /// <summary>
    /// 敌人
    /// </summary>
    public class Enemy : ICloneable
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private int _hp;

        public int Hp
        {
            get => _hp;
            set => _hp = value;
        }

        private Knapsack _knapsack;

        public Knapsack Knapsack
        {
            get => _knapsack;
            set => _knapsack = value;
        }

        public Enemy(string name, int hp, Knapsack knapsack)
        {
            _name = name;
            _hp = hp;
            _knapsack = knapsack;
        }

        public object Clone()
        {
            var clone = (Enemy)MemberwiseClone();
            clone.Knapsack = (Knapsack)_knapsack.Clone();
            return clone;
        }

        public override string ToString()
        {
            return "名字：" + _name + "  血量：" + _hp + _knapsack;
        }
    }
}