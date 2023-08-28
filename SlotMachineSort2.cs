using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineSort2 : MonoBehaviour
{
    public GameObject LeftObj;
    public GameObject CenterObj;
    public GameObject RightObj;

    public List<Sprite> SprtieReference;

    public float StartTime = 0.1f;
    public float StopTime = 10f;

    private float newTime = 0.1f;

    private float maxDelay = 0.1f;
    private float delay = 0.5f;
    private int iteration = 0; // 当前迭代次数

    private float currentTime;


    private bool onlock = true;

    public void TestObjInsertSprite()
    {
        SpriteRenderer leftSprite = LeftObj.GetComponent<SpriteRenderer>();
        leftSprite.sprite = SprtieReference[0];

        SpriteRenderer centerSprite = CenterObj.GetComponent<SpriteRenderer>();
        centerSprite.sprite = SprtieReference[1];

        SpriteRenderer rightSprite = RightObj.GetComponent<SpriteRenderer>();
        rightSprite.sprite = SprtieReference[2];
    }

    public void Shuffle()
    {
        // 目前沒有使用 invoke 特性
        // 因為放置 Update

        // 我計算完之後
        // 鎖起來
        // 過一段時間後
        // 再打開



            //newTime = Mathf.Lerp(maxDelay, delay, (float)iteration / 100);
            //iteration++;

        //Invoke(nameof(LaunchProjectile), newTime);

        LaunchProjectile();
    }
    private void LaunchProjectile()
    {
        Debug.Log("alert");
        if (newTime >= delay) { return; }

        SpriteRenderer leftSprite = LeftObj.GetComponent<SpriteRenderer>();
        leftSprite.sprite = SprtieReference[Random.Range(0, 3)];

        Debug.Log($"內{newTime}");

        Shuffle();
        //Invoke(nameof(Shuffle), Time.deltaTime);


    }


    // 拿取 父物件 內 三個子物件
    // 直接拿取 不要透過層級 麻煩

    // 遊戲表演時間開始
    // Create 三個欄位 Sprtie
    // Single 欄位Shuffle

    // 看撲克牌參考
    // 塞入圖片
    // 刪除圖片
    // 再塞入新圖片

    // 遊戲表時間結束
    // 停止刷新圖片

    // 分析結果
    // 一樣的 評語 加分
    // 不一樣 評語

    // 關閉遊戲
}
