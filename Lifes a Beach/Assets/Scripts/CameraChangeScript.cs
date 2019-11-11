using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeScript : MonoBehaviour
{
    
    public GameObject vCam;


    private void Start()
    {
        vCam.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        vCam.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        vCam.SetActive(false);
    }
}
