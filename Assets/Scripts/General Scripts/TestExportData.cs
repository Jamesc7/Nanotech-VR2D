using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestExportData : MonoBehaviour {
    //public ExportData data;
    //public GameObject hand;
    public static int counter;
    int stopper;
    private Valve.VR.InteractionSystem.Hand handItem;

    private void Start()
    {
        stopper = Valve.VR.InteractionSystem.Hand.counter;
        //ExportData.Save(1);
    }
    private void Update()
    {

        // For testing, next time in the hand script, try to count how many times the sphere is grabbed
        
        if (Valve.VR.InteractionSystem.Hand.counter != stopper)
        {
            ExportData.Save(1);
            stopper++;
            Debug.Log("stopper: "+ stopper);
        }
        
    }
}