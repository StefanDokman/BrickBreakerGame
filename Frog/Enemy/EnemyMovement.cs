using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movement = 2;
    public float MovementSpeed = 1;
    public GameObject Enemy;
    private Rigidbody2D _rigidbody;
    void Start()
    {
        this.Enemy = gameObject;
        _rigidbody = Enemy.GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        Enemy.transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
