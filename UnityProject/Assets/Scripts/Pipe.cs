using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : Ground
{
    private void Start()
    {
        //刪除Clone
        Destroy(gameObject,5.0f);
    }
}