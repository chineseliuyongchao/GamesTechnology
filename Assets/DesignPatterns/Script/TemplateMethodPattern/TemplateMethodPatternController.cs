using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Script.TemplateMethodPattern
{
    /// <summary>
    /// 模版方法模式
    /// 在基类中实现整套流程，并且将某些步骤可能会修改的部分通过虚方法提供派生类重写
    /// </summary>
    public class TemplateMethodPatternController : MonoBehaviour
    {
        private List<BaseEnemy> _enemies;
        private const int ENEMY_COUNT = 5;

        private void Awake()
        {
            _enemies = new List<BaseEnemy>();
            for (int i = 0; i < ENEMY_COUNT; i++)
            {
                _enemies.Add(new PrimaryEnemy(Random.Range(1, 100).ToString()));
            }

            for (int i = 0; i < ENEMY_COUNT; i++)
            {
                _enemies.Add(new SeniorEnemy(Random.Range(1, 100).ToString()));
            }
        }

        private void Start()
        {
            for (int i = 0; i < _enemies.Count; i++)
            {
                _enemies[i].StartAttack();
            }
        }
    }
}