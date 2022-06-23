using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem _explosion;
    [SerializeField] private GameObject[] _forceUp; //declaring an array of objects that will be exposed by script

    private bool _isStartBoom = false; //mark for AddForce when it should work
    private Vector3 impulse = new Vector3(0f, 7.0f, 0f); //set specified vector for AddForce

    private void Start()
    {
        _explosion.GetComponent<ParticleSystem>(); //initialize ParticleSystem component 
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object is entered to trigger");
        _explosion.Play(); //so explosion starts everyrime when orher collider entered in trigger
        _isStartBoom = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object has left trigger");
    }

    private void FixedUpdate() //FixedUpdate is used for Rigidbody component
    {
        if (_isStartBoom)
        {
            foreach (GameObject obj in _forceUp)
            {
                obj.GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse); //add impulse for objects in massive _forceUp
            }
            _isStartBoom = false; //mark that impulse should only one time for object in massive after 
        }
    }
}
