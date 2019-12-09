using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrollingBody : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 newPos;
    private Vector2 newPos1;
    private Vector2 restart;

    public GameObject player;
    public float moveSpeed = 1;


    public void Awake()
    {
        //stores the player initial position as the restart position
        if (player == null)
        {
            player = Instantiate(Resources.Load<GameObject>("Prefab/character"));
        }
       // else
       // {
       //     player = GameObject.Find("character");
       // }
        restart = player.transform.position;
    }

    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // get reference
        //set velocity
        //if the rigidbody is rotated, then go the different direction
        if (rb2d.transform.rotation.y == 0f)
        {
            rb2d.velocity = new Vector2(2.0f * moveSpeed, 0);
        }
        else
        {
            //could use 1.5f as a public variable later 
            // so all cars move same speed
            rb2d.velocity = new Vector2(-2.0f * moveSpeed, 0); 
        }
    }

    // Update is called once per frame
    public void Update()
    {
        //use the player restart x position as center for the car restart position
        //because the player will always be the center of the screen
        newPos = new Vector2(restart.x - 10.0f, rb2d.position.y);
        newPos1 = new Vector2(restart.x + 10.0f, rb2d.position.y);
        if (rb2d.transform.rotation.y == 0f)
        {
            if (rb2d.position.x >= restart.x + 10.0f)
            {
                rb2d.position = newPos;
            }
        }
        else
        {
            if (rb2d.position.x <= restart.x - 10.0f)
            {
                rb2d.position = newPos1;
            }
        }
    }
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "character")
        {
            Rigidbody2D character = collision.rigidbody;
            character.position = restart;
            character.velocity = new Vector2(0, 0); 
        }

    }

    public Rigidbody2D getRb2d()
    {
        return rb2d;
    }


    public Vector2 getRestartPos()
    {
        return restart;
    }

    public void setRb2d(Rigidbody2D rigid)
    {
        rb2d = rigid;
    }

    public GameObject getPlayer()
    {
        return player;
    }
}
