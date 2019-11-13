using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public GameObject ropeComponant;
    private GameObject[] rope;
    public Transform man;
    public Transform dog;
    private Transform ropeStart;
    private Transform ropeEnd;
    public int length;

    void Start()
    {
        rope = new GameObject[length + 1];

        for (int i = 0; i <= length; i++)
        {
            GameObject newRopePiece = Instantiate(ropeComponant, this.transform);
            rope[i] = newRopePiece;
            
            if (i == 0)
            {
                ropeStart = newRopePiece.transform.GetChild(0).transform;
            }

            if (i == length)
            {
                ropeEnd = newRopePiece.transform.GetChild(1).transform;
            }
        }
    }

    void Update()
    {
        ropeStart.position = man.position;
        ropeEnd.position = dog.position;

        Transform leftpos;
        Transform rightPos;

        for (int i = 0; i < length; i++)
        {
            leftpos = rope[i + 1].transform.GetChild(0).transform;
            rightPos = rope[i].transform.GetChild(1).transform;

            if (leftpos != null)
            {
                leftpos.position = rightPos.position;
            }

            
        }
    }
}
