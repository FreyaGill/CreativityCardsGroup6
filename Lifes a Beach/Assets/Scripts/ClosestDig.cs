using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestDig : MonoBehaviour
{
    public GameObject closestDigObj;
    public float closestDigDis;
    public float speed;
    private Vector3 targetRot;

    void Update()
    {

        if (closestDigObj != null)
        {

            closestDigDis = Vector3.Distance(closestDigObj.transform.position, transform.position);
            Vector3 targetDir = closestDigObj.transform.position - transform.position;

            float step = speed * Time.deltaTime;

        }
    }
}
