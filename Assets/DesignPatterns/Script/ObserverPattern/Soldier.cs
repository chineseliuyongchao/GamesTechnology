using UnityEngine;

namespace DesignPatterns.Script.ObserverPattern
{
    /// <summary>
    /// 士兵A
    /// </summary>
    public class SoldierA
    {
        public void Attack()
        {
            Debug.Log("士兵A攻击");
        }
    }

    /// <summary>
    /// 士兵B
    /// </summary>
    public class SoldierB
    {
        public void Attack()
        {
            Debug.Log("士兵B攻击");
        }
    }
}