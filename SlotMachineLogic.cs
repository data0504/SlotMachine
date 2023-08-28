using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineLogic : MonoBehaviour
{
    public SlotMachineButton Button;
    public SlotMachineSort Slot;
    public SlotMachineSort1 Slot1;



    private void Start()
    {
        Slot.TestObjInsertSprite();
    }

    void Update()
    {
        //if (Button.GetOnSlot())
        //{

        //}

        Slot1.Shuffle();


        //Debug.Log($"�ڰʤF");
    }
}
