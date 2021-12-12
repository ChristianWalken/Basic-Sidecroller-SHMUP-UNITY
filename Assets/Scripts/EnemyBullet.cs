using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public GameObject impactEffect;
    public Rigidbody2D projectile;

    public float moveSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(-1,0) * moveSpeed;
    }

        //hit detection
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Left Wall" || col.gameObject.name == "Despawner") 
        {
            Destroy(this.gameObject);
        }else if(col.gameObject.name == "Right Wall"){
             Destroy(this.gameObject);
        }
        if(col.gameObject.name == "Player") 
        {
            Instantiate(impactEffect, this.gameObject.transform.position, Quaternion.Euler(0, 0, -180));
            Destroy(this.gameObject);
        }
    }

}
