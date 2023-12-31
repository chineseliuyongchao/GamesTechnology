using System;

namespace DesignPatterns.Script.ObserverPattern
{
    /// <summary>
    /// 将军
    /// </summary>
    public class General
    {
        public event Action Attack;

        public void StartAttack()
        {
            Attack?.Invoke();
        }
    }
}