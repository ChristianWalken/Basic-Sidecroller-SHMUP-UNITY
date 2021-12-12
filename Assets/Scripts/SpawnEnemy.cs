using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public float SpawnInterval = 15.0f;
    public float currentTime = 9.0f;
    public Transform spawn;
    public GameObject enemy;

    void Start()
    {
        spawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime>=SpawnInterval)
        {   
            Instantiate(enemy, spawn.position,Quaternion.Euler(0, 0, 90));
            currentTime = 0.0f;
        }
    }
}
