using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FrogMovement : MonoBehaviour
{

    //declare local variables
    public float moveSpeed;
    private Animator anim;
    private Rigidbody2D body;

    public bool playerMoving;
    private Vector2 lastMove;

    public int SceneIndex;

    private int lives;
    public Image heart1;
    public Image heart2;
    public Image heart3;

    private GameObject scoreGUI;
    private Text scoreV;

    private void Awake()
    {
        //if player is starting on level one, set score to 0
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayerPrefs.SetInt("Score", 0);
        }
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
        lives = GlobalVariables.lives;
        updateHearts();

        //Get the level based on the scene
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (scene == 5)
            GlobalVariables.level = 1;
        else if (scene == 6)
            GlobalVariables.level = 2;
        else if (scene == 7)
            GlobalVariables.level = 3;
        else //if (scene == 7)
            GlobalVariables.level = 4;

        scoreGUI = GameObject.Find("Score Value");
        scoreV = scoreGUI.GetComponent<Text>();
    }

    // Update is called once per frame
    public void Update()
    {
        //player is default still at start
        playerMoving = false;

        //if horizontal movement is detected
        if ((Input.GetAxisRaw("Horizontal") > 0.5f  && body.position.x < GlobalVariables.Xvalue) || (Input.GetAxisRaw("Horizontal") < -0.5f && body.position.x > GlobalVariables.negXvalue))
        {
            body.velocity = ( new Vector2(1,0) * Input.GetAxis("Horizontal")) * moveSpeed * Time.fixedDeltaTime;
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        //if vertical movement is detected
        else if (Input.GetAxisRaw("Vertical") > 0.5f || (Input.GetAxisRaw("Vertical") < -0.5f && body.position.y > GlobalVariables.negYvalue))
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

        updateScore();
    }

    public Vector2 getFrogVelocity(Rigidbody2D body)
    {
        return body.velocity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if collide with coin
        //collect(destroy) coin
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 100);
            GetComponent<Footsteps>().playCoinSound();
        }
        if (collision.gameObject.name == "Edge Tilemap")
        {
            GlobalVariables.lives = lives; //update lives for next level
            SceneManager.LoadScene(SceneIndex);
        }
    }

    private void updateScore()
    {
        scoreV.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public void SceneLoader(int SceneIndex)
    {

        SceneManager.LoadScene(SceneIndex);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Car") || collision.gameObject.name.Contains("Truck"))
        {
            lives--;
            updateHearts();
            GetComponent<Footsteps>().playHitSound();
        }
    }

    private void updateHearts()
    {
        if (lives == 2)
        {
            heart1.enabled = false;
        }
        if (lives == 1)
        {
            heart1.enabled = false;
            heart2.enabled = false;
        }
        if (lives == 0)
        {
            heart1.enabled = false;
            heart2.enabled = false;
            heart3.enabled = false;
            SceneManager.LoadScene(10); // whatever the end screen is
                                       //end game
        }
    }
}


