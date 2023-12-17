using UnityEngine;

namespace DesignPatterns.Script.TemplateMethodPattern
{
    /// <summary>
    /// 敌人基类
    /// </summary>
    public class BaseEnemy
    {
        protected readonly string Name;

        protected BaseEnemy(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 攻击方法
        /// </summary>
        public void StartAttack()
        {
            FindTarget();
            if (DetermineCanAttack())
            {
                Attack();
            }
        }

        /// <summary>
        /// 寻找目标
        /// </summary>
        protected virtual void FindTarget()
        {
            Debug.Log("敌人" + Name + "寻找目标");
        }

        /// <summary>
        /// 判断是否攻击
        /// </summary>
        /// <returns></returns>
        protected virtual bool DetermineCanAttack()
        {
            Debug.Log("敌人" + Name + "判断目标是否可以攻击");
            return true;
        }

        /// <summary>
        /// 开始攻击
        /// </summary>
        protected virtual void Attack()
        {
            Debug.Log("敌人" + Name + "开始攻击");
        }
    }
}