using UnityEngine;

namespace DesignPatterns.Script.FacadePattern
{
    /// <summary>
    /// 敌人
    /// </summary>
    public class Enemy
    {
        /// <summary>
        /// 寻找目标
        /// </summary>
        public void FindTarget()
        {
            Debug.Log("敌人寻找目标");
        }

        /// <summary>
        /// 准备
        /// </summary>
        public void Preparation()
        {
            Debug.Log("敌人准备");
        }

        /// <summary>
        /// 攻击目标
        /// </summary>
        public void AttackTarget()
        {
            Debug.Log("敌人攻击");
        }

        /// <summary>
        /// 记录目标
        /// </summary>
        public void RecordObjectives()
        {
            Debug.Log("敌人记录");
        }

        /// <summary>
        /// 攻击流程
        /// </summary>
        public void AttackCourse()
        {
            FindTarget();
            Preparation();
            AttackTarget();
            RecordObjectives();
        }

        /// <summary>
        /// 只记录信息的流程
        /// </summary>
        public void OnlyRecordCourse()
        {
        }
    }
}