using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMonsterHeadDetector : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject myGameObject;
    public GameObject DeathDetector;
    public GameObject DeathDetector1;
    public GameObject Player;
    private Rigidbody2D _rigidbody;
    private Rigidbody2D _rigidbody1;
    public float Launch = 2;


    void Start()
    {
        this.myGameObject = gameObject;
        Enemy = gameObject.transform.parent.gameObject;
        Player = GameObject.Find("Player");
        _rigidbody = Player.GetComponent<Rigidbody2D>();
        _rigidbody1 = Enemy.GetComponent<Rigidbody2D>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        DeathDetector.GetComponent<BoxCollider2D>().enabled = false;
        DeathDetector1.GetComponent<BoxCollider2D>().enabled = false;
        Enemy.GetComponent<BoxCollider2D>().enabled = false;
        myGameObject.GetComponent<BoxCollider2D>().enabled = false;
        _rigidbody.AddForce(new Vector2(0, Launch), ForceMode2D.Impulse);
        _rigidbody1.AddForce(new Vector2(0, -1), ForceMode2D.Impulse);
    }


}
