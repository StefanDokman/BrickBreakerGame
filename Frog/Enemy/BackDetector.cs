using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDetector : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
    }


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Zid")
        {
            Enemy.GetComponent<EnemyMovement>().movement = Enemy.GetComponent<EnemyMovement>().movement * (-1);
            if (!Mathf.Approximately(0, Enemy.GetComponent<EnemyMovement>().movement))
                Enemy.transform.rotation = Enemy.GetComponent<EnemyMovement>().movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }

}
