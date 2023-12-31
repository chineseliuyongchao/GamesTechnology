using System;
using UnityEngine;

namespace DesignPatterns.Script.ObserverPattern
{
    /// <summary>
    /// 观察者模式
    /// 将观察者的方法注册给发送者或者发送者的事件，通过接收事件运行对应方法。避免了对象之间的互相调用。
    /// </summary>
    public class ObserverPatternController : MonoBehaviour
    {
        private SoldierA _soldierA;
        private SoldierB _soldierB;
        private General _general;

        private void Awake()
        {
            _soldierA = new SoldierA();
            _soldierB = new SoldierB();
            _general = new General();
            _general.Attack += _soldierA.Attack;
            _general.Attack += _soldierB.Attack;
        }

        private void Start()
        {
            _general.StartAttack();
        }
    }
}