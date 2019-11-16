using UnityEngine;

public class Ground : MonoBehaviour
{
    // 宣告變數 (定義欄位 field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // private 私人(隱藏)，public 公開(顯示)
    // int 整數
    [Header("畫面移動速度"), Range(0,200)]
    public int speed = 10;

    [Header("地板變形元件")]
    public Transform ground;

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
