using UnityEngine;

namespace DesignPatterns.Script.TemplateMethodPattern
{
    /// <summary>
    /// 高级敌人
    /// </summary>
    public class SeniorEnemy : BaseEnemy
    {
        public SeniorEnemy(string name) : base(name)
        {
        }

        protected override void FindTarget()
        {
            Debug.Log("高级敌人" + Name + "寻找目标");
        }

        protected override bool DetermineCanAttack()
        {
            Debug.Log("高级敌人" + Name + "判断可以攻击");
            return true;
        }

        protected override void Attack()
        {
            Debug.Log("高级敌人" + Name + "攻击");
        }
    }
}