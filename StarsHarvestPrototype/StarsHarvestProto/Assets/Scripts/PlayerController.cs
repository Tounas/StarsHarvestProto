using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static float Speed = 5f;
    private float HorizontalInput;
    private float VerticalInput;
    private float BoundaryX = 39.5f;
    private float BoundaryY = 19f;
    public Rigidbody RigidiBody;
    public Vector2 Movement;

    //Gets the rigidbody component for movement, also sets the Speed to be used by movement.
    private void Start()
    {
        RigidiBody = this.GetComponent<Rigidbody>();
        Speed = 5f;
    }

    // If the player tries to move outside the boundary of the game, sets the players position
    // to the boundary
    void Update()
    {
        Movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //Boundaryt liikkumiselle
        if (transform.position.x > BoundaryX)
        {
            transform.position = new Vector3(BoundaryX,transform.position.y, transform.position.z);
        }
        if (transform.position.x < -BoundaryX)
        {
            transform.position = new Vector3(-BoundaryX, transform.position.y, transform.position.z);
        }
        if (transform.position.y > BoundaryY)
        {
            transform.position = new Vector3(transform.position.x, BoundaryY, transform.position.z);
        }
        if (transform.position.y < -BoundaryY)
        {
            transform.position = new Vector3(transform.position.x, -BoundaryY, transform.position.z);
        }
    }

    //Handles the players movement, by calling the proper function.
    private void FixedUpdate()
    {
        PlayerStarMovement(Movement);
    }

    //Handles the movement by adding force to the rigidbody. (For that floaty movement)
    private void PlayerStarMovement(Vector2 Direction)
    {
        RigidiBody.AddForce(Speed * Direction);
    }
}
