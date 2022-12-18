using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public float speed = 10.0f;

    public GameObject projectilePrefab;

    void Update()
    {
        Move();
    }

    // Update is called once per frame
    private void Move()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * verticalMove * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * horizontalMove * Time.deltaTime * speed);
    }
}

