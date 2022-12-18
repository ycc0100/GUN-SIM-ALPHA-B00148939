using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFlying : MonoBehaviour
{

    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //
        }
    }
}
