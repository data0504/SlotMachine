using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineLogic : MonoBehaviour
{
    public SlotMachineButton Button;
    public SlotMachineSort Slot;
    //public SlotMachineSort1 Slot1;



    private void Start()
    {

    }

    void Update()
    {
        if (Button.GetOnSlot())
        {
            if (Slot.RandomResult())
            {
                Slot.LShuffle();
                Slot.CShuffle();
                Slot.RShuffle();

            }

        }

    }
}
