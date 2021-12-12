using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D enemy;
    public int health = 2; 
    public float moveSpeed = 5.0f;
    public float forwardSpeed = 0.5f; 
    public GameObject deathEffect;

    public bool changeDirection = false;

    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
       
    }



    public void moveEnemy()
    {
        if(changeDirection == true){
            enemy.velocity = new Vector2(-forwardSpeed,-moveSpeed) ;
        }else if(changeDirection == false){
            enemy.velocity = new Vector2(-forwardSpeed,moveSpeed);
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Top Wall"){
            changeDirection = true; 
        }
        else if(col.gameObject.name == "Bottom Wall"){
            changeDirection = false;
        }
        else if(col.gameObject.name == "Player" || col.gameObject.name == "Despawner"){
            changeDirection = false;
            Instantiate(deathEffect, this.gameObject.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    public void deductHealth()
    {
        health -=1;
    }


}
