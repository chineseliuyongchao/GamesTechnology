using UnityEngine;

namespace DesignPatterns.Script.TemplateMethodPattern
{
    /// <summary>
    /// 低级敌人
    /// </summary>
    public class PrimaryEnemy : BaseEnemy
    {
        public PrimaryEnemy(string name) : base(name)
        {
        }

        protected override bool DetermineCanAttack()
        {
            bool res = Random.Range(1, 10) > 5;
            Debug.Log("初级敌人" + Name + (res ? "判断可以攻击" : "判断不可以攻击"));
            return res;
        }

        protected override void Attack()
        {
            Debug.Log("初级敌人" + Name + "攻击");
        }
    }
}