using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasCloudMovement : MonoBehaviour
{
    public static float Speed = 2;
    private float DirectionSpeed;
    private float BoundaryOfX = 43f;
    private float BoundaryOfY = 21f;
    private float ScoreKeeper = CloudPickUp.ScoreFromCloud;

    //Movement for the cloud pickups. Also handles boundary (if out of bounds, destroy object)
    void Update()
    {
        this.transform.Translate(Vector3.up * Speed * Time.deltaTime);
        
        if (transform.position.x > BoundaryOfX)
        {
            DestroyThisObject();
        }
        else if (transform.position.x < -BoundaryOfX)
        {
            DestroyThisObject();
        }
        if (transform.position.y > BoundaryOfY)
        {
            DestroyThisObject();
        }
        else if (transform.position.y < -BoundaryOfY)
        {
            DestroyThisObject();
        }
    }

    private void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }
}
