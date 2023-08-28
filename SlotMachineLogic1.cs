using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachineLogic1 : MonoBehaviour
{
    public SlotMachineButton Button;
    public SlotMachineSort Slot;
    public SlotMachineSort2 Slot2;



    private void Start()
    {
        //Debugdelay();
        //Invoke("Debugdelay", 1f);

        //Invoke("Debugdelay",3.7f);

        //Invoke("Debugdelay", 5f);


        //for (int i = 0; i < 10; i++)
        //{
        //    Slot2.Shuffle();
        //}

        Slot2.Shuffle();

    }

    private void Debugdelay()
    {
        Debug.Log(Time.time);

        //Invoke(nameof(Debugdelay), 0.2f);
    }
}
