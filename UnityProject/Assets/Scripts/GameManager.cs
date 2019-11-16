using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int Npoint;
    [Header("最高分數")]
    public int Hpoint;
    [Header("水管")]
    //GameObject 可以存放場景上的遊戲物件與專案的預製物
    public GameObject pipe;


    private void SpawnPipe()
    {
        print("生水管");
        //生成物件
        //Object.Instantiate(pipe);

        //生成(物件，座標，角度)

        Vector3 pos = new Vector3(0, Random.Range(-1.9f,1.5f), 0);

        //Quaternion.identity代表零角度
        Instantiate(pipe, pos, Quaternion.identity);
    }

    private void Start()
    {
        //重複調用("方法名稱",開始時間,間隔時間);
        InvokeRepeating("SpawnPipe", 0, 1.5f);
    }
}
