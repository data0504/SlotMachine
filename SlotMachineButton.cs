using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineButton : MonoBehaviour
{
    private bool onSlot;

    //給
    public bool GetOnSlot()
    {
        return onSlot;
    }

    //設定
    public void SetOnSlot()
    {
        onSlot = false;
    }

    //偵測
    void OnMouseDown()
    {
        onSlot = true;
        Debug.Log("我按了");
    }
}
