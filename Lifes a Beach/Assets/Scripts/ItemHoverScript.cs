using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHoverScript : MonoBehaviour
{
    public GameObject item;
    public Vector3 startPos;
    public Vector3 startPos1;
    public Vector3 endPos;
    public Vector3 endPos1;
    public float lerpTime = 5;
    public float currentLerpTime = 0;
    public float distance = 30f;
    public GameObject vCam;
    private void Start()
    {
        vCam.SetActive(false);
        startPos = item.transform.position;
        endPos = item.transform.position + Vector3.up * distance;
        endPos1 = item.transform.position + Vector3.down * distance;

    }
    private void OnMouseOver()
    {
        MoveItemUp();
    }


    private void MoveItemUp()
    {

        vCam.SetActive(true);
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime >= lerpTime)
        {
            currentLerpTime = lerpTime;
        }

        float Perc = currentLerpTime / lerpTime;
        item.transform.position = Vector3.Lerp(startPos, endPos, Perc);


    }

    private void OnMouseExit()
    {
        vCam.SetActive(false);
    }

    /*
    private void OnMouseExit()
    {
        currentLerpTime += Time.deltaTime;
        
        if (currentLerpTime >= lerpTime)
        {
            currentLerpTime = lerpTime;
        }
        
    
        float Perc = currentLerpTime / lerpTime;

        item.transform.position = Vector3.Lerp(startPos1, endPos1, Perc);

    }
    */

}
