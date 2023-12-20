using UnityEngine;

namespace DesignPatterns.Script.FacadePattern
{
    /// <summary>
    /// 外观模式
    /// 可以将较为复杂的流程封装起来，只给外部提供一个调用接口，逻辑清晰，方便调用和后续改动
    /// </summary>
    public class FacadePatternController : MonoBehaviour
    {
        private Enemy _enemy;

        private void Awake()
        {
            _enemy = new Enemy();
        }

        private void Start()
        {
            //不使用外观模式，需要把Enemy内部的方法按照一定顺序调用，导致外部需要较多了解内部实现，不方便调用也不方便内部改动
            if (CanAttack())
            {
                //如果可以攻击
                _enemy.FindTarget();
                _enemy.Preparation();
                _enemy.AttackTarget();
                _enemy.RecordObjectives();
            }
            else
            {
                //如果不能攻击
                _enemy.FindTarget();
                _enemy.RecordObjectives();
            }

            //使用外观模式以后，只要调用对应流程，不需要关注内部实现
            if (CanAttack())
            {
                //如果可以攻击
                _enemy.AttackCourse();
            }
            else
            {
                //如果不能攻击
                _enemy.OnlyRecordCourse();
            }
        }

        /// <summary>
        /// 判断是否可以攻击
        /// </summary>
        /// <returns></returns>
        private bool CanAttack()
        {
            return Random.Range(0, 5) < 3;
        }
    }
}