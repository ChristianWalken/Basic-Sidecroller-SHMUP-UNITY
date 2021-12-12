using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootControl : MonoBehaviour
{


    public Transform spawn;
    public GameObject bullet;
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        spawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    public void shoot()
    {
        currentTime += Time.deltaTime;

        if(Input.GetKeyDown("space") && currentTime > nextFire)
        {

            Instantiate(bullet, spawn.position,Quaternion.Euler(0, 0, -90));
            currentTime = 0.0f;
        }
    }
}
