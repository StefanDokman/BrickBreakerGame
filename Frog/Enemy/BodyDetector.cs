using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyDetector : MonoBehaviour
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
        if (other.tag == "Teren")
        {
            Enemy.GetComponent<EnemyMovement>().movement = Enemy.GetComponent<EnemyMovement>().movement * (-1);
            if(Enemy.GetComponent<EnemyMovement>().movement == 1)
                Enemy.transform.rotation = Quaternion.Euler(new Vector3(0, -180, 0));
            if (Enemy.GetComponent<EnemyMovement>().movement == -1)
                Enemy.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));





        }
    }


}