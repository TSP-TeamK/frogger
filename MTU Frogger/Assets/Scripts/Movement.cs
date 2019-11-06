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
	speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //get right key
        if (Input.GetKey(KeyCode.RightArrow))
        {
		Vector2 movement = new Vector2(speed, 0);
            frog.AddForce(movement);
        }
        //get left key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 movement = new Vector2(-speed, 0);
            frog.AddForce(movement);
        }
        //get up key
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 movement = new Vector2(0, speed);
            frog.AddForce(movement);
        }
        //get down key
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 movement = new Vector2(0, -speed);
            frog.AddForce(movement);
        }
    }
}
