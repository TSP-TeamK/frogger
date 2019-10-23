using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBodyBackwards : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 newPos = new Vector2(12.0f, 0.0f);
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // get reference
        //set velocity
        rb2d.velocity = new Vector2(-2.0f, 0); //could use 1.5f as a public variable later 
                                                // so all cars move same speed
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (GameControl.instance.gameOver = true) {rb2d.velocity = Vector2.zero}
        //We don't currently have a gameOver thing

        if( rb2d.position.x <= -13f)
        {
            rb2d.position = newPos;
        }
    }
}
