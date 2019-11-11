using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestDig : MonoBehaviour
{
    public GameObject closestDigObj;
    public float closestDigDis;
    public float soundIntensity;

    void Update()
    {

        if (closestDigObj != null)
        {
            closestDigDis = Vector3.Distance(closestDigObj.transform.position, transform.position);
        }
    }
}
