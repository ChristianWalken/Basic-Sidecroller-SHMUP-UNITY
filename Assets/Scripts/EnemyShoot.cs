using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject projectile;

    public Transform projectileSpawn;

    public float nextFire = 1.0f;
    public float currentTime = 0.0f; 
    void Start()
    {
        projectileSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyShoot();
    }

    public void enemyShoot()
    {
        currentTime += Time.deltaTime;

        if (currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(projectile, projectileSpawn.position, Quaternion.identity);
            
            nextFire -= currentTime;
            currentTime = 0.0f;
            
        }
    }
}
