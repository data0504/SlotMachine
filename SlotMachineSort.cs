using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineSort : MonoBehaviour
{
    public GameObject LeftObj;
    public GameObject CenterObj;
    public GameObject RightObj;
    public List<Sprite> SprtieReference;

    private List<int> resultSort;
    private bool resultOff;

    private const float delay = 0.1f;
    private const float maxDelay = 0.5f;


    private float newTimeL;
    private float newTimeC;
    private float newTimeR;

    public int LfirstIndex = 0;
    public int CfirstIndex = 0;
    public int RfirstIndex = 0;


    private int iterationL = 0;
    private float currentTimeL;

    private int iterationC = 0;
    private float currentTimeC;

    private int iterationR = 0;
    private float currentTimeR;


    public bool RandomResult()
    {
        if (!resultOff)
        {
            resultSort = new();
            for (int i = 0; i < 3; i++) { resultSort.Add(Random.Range(0, 3)); }
            Debug.Log($"{resultSort[0]}, {resultSort[1]},{resultSort[2]}");
            resultOff = true;
        }

        return resultOff;
    }
    private bool CheckIndexResultL()
    {
        if (resultSort[0] == LfirstIndex ) return true;
        return false;
    }
    private bool CheckIndexResultC()
    {
        if (resultSort[1] == CfirstIndex) return true;
        return false;
    }
    private bool CheckIndexResultR()
    {
        if (resultSort[2] == RfirstIndex) return true;
        return false;
    }


    public void LShuffle()
    {
        newTimeL = Mathf.Lerp(delay, maxDelay, (float)iterationL / 100);
        currentTimeL += Time.deltaTime;
        if (currentTimeL > newTimeL)
        {
            SpriteRenderer leftSprite = LeftObj.GetComponent<SpriteRenderer>();
            //SpriteRenderer centerSprite = CenterObj.GetComponent<SpriteRenderer>();
            //SpriteRenderer rightSprite = RightObj.GetComponent<SpriteRenderer>();
            currentTimeL = 0;
            iterationL++;

            if (newTimeL >= maxDelay)
            {
                if (CheckIndexResultL())
                {
                    Debug.Log("結束");
                    Debug.Log($"{resultSort[0]} and {LfirstIndex}");
                    return;
                }
            }

            LSortImg(leftSprite);
        }
    }
    public void CShuffle()
    {
        newTimeC = Mathf.Lerp(delay, maxDelay, (float)iterationC / 100);
        currentTimeC += Time.deltaTime;
        if (currentTimeC > newTimeC)
        {
            //SpriteRenderer leftSprite = LeftObj.GetComponent<SpriteRenderer>();
            SpriteRenderer centerSprite = CenterObj.GetComponent<SpriteRenderer>();
            //SpriteRenderer rightSprite = RightObj.GetComponent<SpriteRenderer>();
            currentTimeC = 0;
            iterationC++;

            if (newTimeC >= maxDelay)
            {
                if (CheckIndexResultC())
                {
                    Debug.Log("結束");
                    Debug.Log($"{resultSort[1]} and {CfirstIndex}");
                    return;
                }
            }

            CSortImg(centerSprite);
        }
    }
    public void RShuffle()
    {
        newTimeR = Mathf.Lerp(delay, maxDelay, (float)iterationR / 100);
        currentTimeR += Time.deltaTime;
        if (currentTimeR > newTimeR)
        {
            //SpriteRenderer leftSprite = LeftObj.GetComponent<SpriteRenderer>();
            //SpriteRenderer centerSprite = CenterObj.GetComponent<SpriteRenderer>();
            SpriteRenderer rightSprite = RightObj.GetComponent<SpriteRenderer>();
            currentTimeR = 0;
            iterationR++;

            if (newTimeR >= maxDelay)
            {
                if (CheckIndexResultR())
                {
                    Debug.Log("結束");
                    Debug.Log($"{resultSort[2]} and {RfirstIndex}");
                    return;
                }
            }

            RSortImg(rightSprite);
        }
    }

    public void LSortImg(SpriteRenderer sprite)
    {
        if (LfirstIndex == 0)
        {
            sprite.sprite = SprtieReference[LfirstIndex];
            LfirstIndex++;
            return;
        }
        if (LfirstIndex == 1)
        {
            sprite.sprite = SprtieReference[LfirstIndex];
            LfirstIndex++;
            return;
        }
        if (LfirstIndex == 2)
        {
            sprite.sprite = SprtieReference[LfirstIndex];
            LfirstIndex = 0;
            return;
        }
    }
    public void CSortImg(SpriteRenderer sprite)
    {
        if (CfirstIndex == 0)
        {
            sprite.sprite = SprtieReference[CfirstIndex];
            CfirstIndex++;
            return;
        }
        if (CfirstIndex == 1)
        {
            sprite.sprite = SprtieReference[CfirstIndex];
            CfirstIndex++;
            return;
        }
        if (CfirstIndex == 2)
        {
            sprite.sprite = SprtieReference[CfirstIndex];
            CfirstIndex = 0;
            return;
        }
    }
    public void RSortImg(SpriteRenderer sprite)
    {
        if (RfirstIndex == 0)
        {
            sprite.sprite = SprtieReference[RfirstIndex];
            RfirstIndex++;
            return;
        }
        if (RfirstIndex == 1)
        {
            sprite.sprite = SprtieReference[RfirstIndex];
            RfirstIndex++;
            return;
        }
        if (RfirstIndex == 2)
        {
            sprite.sprite = SprtieReference[RfirstIndex];
            RfirstIndex = 0;
            return;
        }
    }


    // 拿取 父物件 內 三個子物件
    // 直接拿取 不要透過層級 麻煩


    // 先有結果 再開始表演


    // 遊戲表演時間開始
    // Create 三個欄位 Sprtie OK
    // Single 欄位Shuffle OK

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
