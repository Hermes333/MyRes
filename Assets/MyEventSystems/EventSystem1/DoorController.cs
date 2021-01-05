using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;
    // Start is called before the first frame update
    private void Start()
    {
        GameEvents.current.onDoorWayTriggerEnter += onDoorWayOpen;
        GameEvents.current.onDoorWayTriggerExit += onDoorWayClose;
    }


    private void onDoorWayOpen(int id)
    {
       
        Debug.Log("OntriggerEnter");
        if (id == this.id)
            LeanTween.moveLocalY(gameObject, 1.6f, 1.6f).setEaseLinear();

    }

    private void onDoorWayClose(int id)
    {
        if (id == this.id)
            LeanTween.moveLocalY(gameObject, 0, 1.6f).setEaseLinear();

    }
}
