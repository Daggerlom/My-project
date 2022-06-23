using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SphereTrigger") //if object with tag SphereTrigger is entered to trigger log message
        {
            Debug.Log("Sphere collider entered in trigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "SphereTrigger")
        {
            Debug.Log("Sphere collider exit from trigger");
        }
    }
}
