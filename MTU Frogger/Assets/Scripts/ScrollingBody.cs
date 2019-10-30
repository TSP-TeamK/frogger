using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBody : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private Vector2 newPos;
    private Vector2 restart = new Vector2(0, -4);
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // get reference
        //set velocity
        rb2d.velocity = new Vector2(2.0f, 0); //could use 1.5f as a public variable later 
                                                // so all cars move same speed
    }

    // Update is called once per frame
    void Update()
    {
        //if (GameControl.instance.gameOver = true) {rb2d.velocity = Vector2.zero}
        //We don't currently have a gameOver thing

        newPos = new Vector2(-12.0f, rb2d.position.y);

        if( rb2d.position.x >= 13f)
        {
            rb2d.position = newPos;
        }
    }
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "character")
        {
            Rigidbody2D character = collision.rigidbody;
            Rigidbody2D car = collision.otherRigidbody;
            character.position = restart;
            character.velocity = new Vector2(0, 0);
            car.velocity = new Vector2(2.0f, 0);

        }

    }
}
