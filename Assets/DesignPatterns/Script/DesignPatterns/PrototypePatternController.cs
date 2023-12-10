using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Script.DesignPatterns
{
    /// <summary>
    /// 原型模式
    /// 通过在对象内部实现ICloneable来提供内部复制新对象，浅拷贝可以通过MemberwiseClone方法直接拷贝，深拷贝需要通过具体情况实现。相较于外部调用构造方法代码简洁。逻辑合理，性能方面暂未发现区别。
    /// </summary>
    public class PrototypePatternController : MonoBehaviour
    {
        private List<Enemy> _enemies;
        private const int ENEMY_COUNT = 10;

        private void Awake()
        {
            _enemies = new List<Enemy>();
            _enemies.Add(new Enemy("小兵", 100, new Knapsack("刀", "扎甲")));
            for (int i = 0; i < ENEMY_COUNT; i++)
            {
                _enemies.Add((Enemy)_enemies[0].Clone());
            }

            _enemies[ENEMY_COUNT / 3].Knapsack.Weapon = "剑";
            _enemies[ENEMY_COUNT / 2].Knapsack.Armor = "链甲";
        }

        private void Start()
        {
            for (int i = 0; i < _enemies.Count; i++)
            {
                Debug.Log("第" + i + "个的信息：" + _enemies[i]);
            }
        }
    }
}