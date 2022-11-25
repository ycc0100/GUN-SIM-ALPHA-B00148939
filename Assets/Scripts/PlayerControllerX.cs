using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 6f;
    public float verticalMove;
    public float horizontalMove;
    public CharacterController gun;

    void Update()
    {
        Move();
    }

    // Update is called once per frame
    private void Move()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");

        Vector3 moveon = transform.forward * verticalMove + transform.right * horizontalMove;
        gun.Move(speed * Time.deltaTime * moveon);
    }
}

//moving method based on this website: https://itnext.io/how-to-write-a-simple-3d-character-controller-in-unity-1a07b954a4ca