using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class TestManagerMain : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            if(TestManager.Instance != null)
            {
                Debug.Log("Test Manager exists and his value is " +  TestManager.Instance.GetTestValue());
            }
            else
            {
                Debug.Log("Test Manager does not exist in the scene");
            }
        }
    }

}
