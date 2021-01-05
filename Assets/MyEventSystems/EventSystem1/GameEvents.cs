using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    // Start is called before the first frame update
    void Awake()
    {
        current = this;
    }

    public event Action<int> onDoorWayTriggerEnter;
    public event Action<int> onDoorWayTriggerExit;

    public void DoorwayTriggerEnter(int i)
    {

        if(onDoorWayTriggerEnter !=null)
        {
            onDoorWayTriggerEnter(i);
        }
    }

    public void DoorwayTriggerExit(int i)
    {

        if (onDoorWayTriggerExit != null)
        {
            onDoorWayTriggerExit(i);
        }
    }
}
