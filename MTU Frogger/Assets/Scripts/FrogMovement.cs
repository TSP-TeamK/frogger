using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{

    //declare local variables
    public float moveSpeed;
    private Animator anim;
    private Rigidbody2D body;

    private bool playerMoving;
    private Vector2 lastMove;

    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //player is default still at start
        playerMoving = false;

        //if horizontal movement is detected
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            body.velocity = ( new Vector2(1,0) * Input.GetAxis("Horizontal")) * moveSpeed * Time.fixedDeltaTime;
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        //if vertical movement is detected
        else if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            body.velocity = (transform.up * Input.GetAxis("Vertical")) * moveSpeed * Time.fixedDeltaTime;
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        else body.velocity = new Vector2(0,0);

        //set variables for movement
        anim.SetFloat("Move X", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("Move Y", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }

}
