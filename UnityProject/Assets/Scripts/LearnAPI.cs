using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform TA;
    public Transform BR;
    public Camera De;
    public AudioSource stop;
    private void Start()
    {
        //靜態成員用法
        print(Random.value);
        print(Mathf.PI);
        print(Random.Range(1, 100));
        print(Mathf.Abs(-99));

        //動態成員用法
        //需要先給予欄位存放實體物件
        stop.Stop();
        BR.position = new Vector3(1, 0, 0);
        print(TA.position);
        print(De.depth);
    }

    private void Update()
    {
        BR.Rotate(0,0,10);
    }
}
