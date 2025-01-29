using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Managers
{
    public class TestManager : Manager<TestManager>
    {
        [SerializeField]
        private int TestValue;

        public int GetTestValue() { return TestValue; }
    }
}

