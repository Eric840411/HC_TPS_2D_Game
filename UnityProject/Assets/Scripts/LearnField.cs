using UnityEngine;

public class LearnField : MonoBehaviour
{
    //定義欄位 Field
    //語法：欄位類型 欄位名稱 (指定 值) 結束

    //私人：隱藏 private(預設)
    //公開：顯示 public

    //整數 int
    //浮點數 float
    //字串 string
    //布林值 bool (預設 false)

    [Header("角色等級")]
    [Range(1, 99)]
    public int lv = 1;
    [Tooltip("角色的移動速度")]//滑鼠移動註解
    [Range(0.1f,99.9f)]
    public float speed = 1.5f;
    public string prop = "紅色藥水" ;
    public bool misson = true;

}
