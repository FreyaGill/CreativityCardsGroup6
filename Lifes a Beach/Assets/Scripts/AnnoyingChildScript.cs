using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnnoyingChildScript : MonoBehaviour
{

    private GameObject Player;

    NavMeshAgent Enemy;

    private GameObject body;

    private GameObject fallenOver;


    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Dog");

        body = this.gameObject.transform.GetChild(0).gameObject;
      
        fallenOver = this.gameObject.transform.GetChild(1).gameObject;
    }


    void Update()
    {
        Enemy.SetDestination(Player.transform.position);
    }

    

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
    }



    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            // player smacks 
            transform.DetachChildren();
            fallenOver.SetActive(true);
            Destroy(body);
            Destroy(this.gameObject);

        }
    }

}



