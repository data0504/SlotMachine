using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineButton : MonoBehaviour
{
    private bool onSlot;

    //��
    public bool GetOnSlot()
    {
        return onSlot;
    }

    //�]�w
    public void SetOnSlot()
    {
        onSlot = false;
    }

    //����
    void OnMouseDown()
    {
        onSlot = true;
        Debug.Log("�ګ��F");
    }
}
