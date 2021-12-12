using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{

    public GameObject impactEffect;
    public GameObject deathEffect;
    public Rigidbody2D projectile;

    public float moveSpeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(1,0)*moveSpeed;
    }


    //hit detection
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy(Clone)") 
        {
            Enemy enemy = col.gameObject.GetComponent<Enemy>();
            if(enemy.health == 0)
            {
                Instantiate(deathEffect, this.gameObject.transform.position, Quaternion.identity);
                DestroyObject(col.gameObject);
                DestroyObject(this.gameObject);
            }else
            {
                enemy.deductHealth();
                Instantiate(impactEffect, this.gameObject.transform.position, Quaternion.identity);
                DestroyObject(this.gameObject);
            }
          
        }
          if(col.gameObject.name == "Right Wall"){
             DestroyObject(this.gameObject);
        }
    }
}
