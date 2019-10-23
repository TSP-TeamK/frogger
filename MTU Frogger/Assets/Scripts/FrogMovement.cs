using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    //a rigid body for the frog
    Rigidbody2D frog = new Rigidbody2D();
    //set speed for frog
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //get the frog Rigidbody2D
        frog = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //get right key
        if (Input.GetKey(KeyCode.RightArrow))
        {
            frog.velocity = transform.right * speed;
        }
        //get left key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            frog.velocity = -transform.right * speed;
        }
        //get up key
        if (Input.GetKey(KeyCode.UpArrow))
        {
            frog.velocity = transform.up * speed;
        }
        //get down key
        if (Input.GetKey(KeyCode.DownArrow))
        {
            frog.velocity = -transform.up * speed;
        }
    }
}
