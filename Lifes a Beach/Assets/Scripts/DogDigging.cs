using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDigging : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "DigSpot") &&(Input.GetKey(KeyCode.RightShift)))
        {
            print("Got Treasure!");
            Destroy(other.gameObject);
        }
    }
}
