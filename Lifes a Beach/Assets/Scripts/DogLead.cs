using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogLead : MonoBehaviour
{
    public Transform man;
    public Transform dog;
    private LineRenderer leadLine;
    public int maxDistance;
    private float currentDistance;

    void Start()
    {
        leadLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        currentDistance = Vector3.Distance(man.position, dog.position);

        for (int i = 0; i < leadLine.positionCount; i++)
        {
            if (i == 0)
            {
                leadLine.SetPosition(i , man.position);
            }

            if (i - 1 == leadLine.positionCount)
            {
                leadLine.SetPosition(i, dog.position);
            }

            else
            {
                float point = i / leadLine.positionCount;
                float sag = (maxDistance - currentDistance) / 5;
                Vector3 newPos = new Vector3(currentDistance * point,
                                             man.position.y - ((man.position.y - dog.position.y) / sag),
                                             man.position.z - ((man.position.z - dog.position.z) / point));
                Debug.Log(man.position.x - ((man.position.x - dog.position.x) / point));
            }
        }        
    }
}
