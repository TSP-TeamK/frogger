//This script is used for cars on US41 on level 3 that are traveling from left to right


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3US41Cars : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 newPos;
    private Vector2 newPos1;
    private Vector2 restart;
    public GameObject player;
    public float moveSpeed = 1;
    public bool stop = false;

	private void Awake()
    {
        //stores the player initial position as the restart position
        if (player == null)
        {
            player = Instantiate(Resources.Load<GameObject>("Prefab/character"));
        }
        else
        {
            player = GameObject.Find("character");
        }
        restart = player.transform.position;

    }
    // Start is called before the first frame update
    void Start()
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
    void Update()
    {
	/*if (!GlobalVariables.L3light) {
		stop = false;
	}*/
        //use the player restart x position as center for the car restart position
        //because the player will always be the center of the screen
        newPos = new Vector2(restart.x - 10.0f, rb2d.position.y);
        newPos1 = new Vector2(restart.x + 10.0f, rb2d.position.y);
        if (rb2d.transform.rotation.y == 0f)//cars going from left to right
        {
            if (rb2d.position.x >= restart.x + 10.0f)
            {
                rb2d.position = newPos;
            }
		if (stop || (GlobalVariables.L3light && (rb2d.position.x > -7f && rb2d.position.x < -6.5f))) {//light is on (red), stop!
			rb2d.velocity = new Vector2(0, 0); 
		}
		else {
			rb2d.velocity = new Vector2(2.0f * moveSpeed, 0); 
		}
        }
        else//cars going from right to left
        {
            if (rb2d.position.x <= restart.x - 10.0f)
            {
                rb2d.position = newPos1;
            }
		if (GlobalVariables.L3light && (rb2d.position.x > 0f && rb2d.position.x < .5f)) {
			rb2d.velocity = new Vector2(0, 0);
		}
		else {
			rb2d.velocity = new Vector2(-2.0f * moveSpeed, 0);
		}
        }
    }

void OnCollisionEnter2D(Collision2D collision)
    {
	Debug.Log("Collision!");
        if (collision.gameObject.name == "character")
        {
            Rigidbody2D character = collision.rigidbody;
            character.position = restart;
            character.velocity = new Vector2(0, 0);
        }

	else /*if (GlobalVariables.L3light)*/ {
		Debug.Log("Car!");
		//stop = true;
	}
    }

    public Rigidbody2D getRb2d()
    {
        return rb2d;
    }
}
