using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDetector : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject BodyDetector;
    public GameObject myGameObject;
    public GameObject Player;
    private Rigidbody2D _rigidbody;
    public float Launch = 2;


    void Start()
    {
        this.myGameObject = gameObject;
        Enemy = gameObject.transform.parent.gameObject;
        Player = GameObject.Find("Player");
        BodyDetector = GameObject.Find("BodyDetector");
        _rigidbody = Player.GetComponent<Rigidbody2D>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

            Enemy.GetComponent<BoxCollider2D>().enabled = false;
            myGameObject.GetComponent<BoxCollider2D>().enabled = false;
            BodyDetector.GetComponent<BoxCollider2D>().enabled = false;
            _rigidbody.AddForce(new Vector2(0, Launch), ForceMode2D.Impulse);
        
    }


}