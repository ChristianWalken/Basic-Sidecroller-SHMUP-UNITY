using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 7.0f;

    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
         player = this.GetComponent<Rigidbody2D>();         
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer ();
    }

    public void MovePlayer()
    {
        player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
    }
}
