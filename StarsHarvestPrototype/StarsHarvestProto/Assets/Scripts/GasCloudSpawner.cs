using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasCloudSpawner : MonoBehaviour
{
    private float SpawnTimer;
    public GameObject GasCloud;
    private float SpawnerLocationX, SpawnerLocationY, SpawnerRotationZ;
    private float RandomizedZRotation;

    //Handles the positions for the spawner and spawning.
    void Start()
    {
        SpawnerLocationX = this.transform.position.x;
        SpawnerLocationY = this.transform.position.y;
        SpawnerRotationZ = transform.rotation.z;
    }

    //when activated, wait for 2 seconds, then spawn the object.
    void Update()
    {
        SpawnTimer += Time.deltaTime;
        if(SpawnTimer >= 2)
        {

            RandomizedZRotation = Random.Range(-40f, 40f);
            Instantiate(GasCloud, new Vector3(SpawnerLocationX,SpawnerLocationY,0), transform.rotation * Quaternion.Euler(0,0,RandomizedZRotation));
            SpawnTimer = 0;
            gameObject.SetActive(false);
        }
    }
}
