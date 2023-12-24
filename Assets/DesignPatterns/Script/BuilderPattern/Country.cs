using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Script.BuilderPattern
{
    /// <summary>
    /// 国家
    /// </summary>
    public class Country
    {
        private List<string> _parts = new List<string>();

        public void AddParts(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Debug.Log("国家组成： " + string.Join(",", _parts));
        }
    }
}