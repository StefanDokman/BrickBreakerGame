using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetector : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "DeathZone")
        {
            Destroy(Enemy.gameObject);
        }
    }
}
