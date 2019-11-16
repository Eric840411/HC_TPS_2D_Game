using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public bool sw;
    [Range(0, 100)]
    public int hp =100;

    private void Update()
    {
       
        if (hp >= 70)
        {
            print("安全");
        }
        else if (hp >= 50)
        {
            print("警告");
        }
        else if (hp >= 20)
        {
            print("危險");
        }
        else
        {
            print("快死了");
        }
    }
}
