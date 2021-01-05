using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int i;
    private void OnTriggerEnter(Collider other)
    {
      
        GameEvents.current.DoorwayTriggerEnter(i);
    }


    private void OnTriggerExit(Collider other)
    {
        GameEvents.current.DoorwayTriggerExit(i);
    }
}
