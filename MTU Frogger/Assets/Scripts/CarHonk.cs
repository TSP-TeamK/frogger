using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHonk : MonoBehaviour
{

    GameObject player;
    private float timeToGo;

    private void Awake()
    {
        player = GameObject.Find("character");
    }

    // Start is called before the first frame update
    void Start()
    {
        timeToGo = Time.fixedTime + Random.Range(1.0f, 3.0f);
    }

    private void Update()
    {
        //if toggle setting is off, mute sound effect
        if (PlayerPrefs.GetInt("ToggleSetting") == 0)
        {
            GetComponent<AudioSource>().Stop();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.fixedTime >= timeToGo)
        {
            {
                //if player is around the car then play honk noises randomly
                if (player.transform.position.y > transform.position.y - 10 ||
                player.transform.position.y < transform.position.y + 10)
                {
                    //randomly play car noises
                    if (Random.Range(1.0f, 50.0f) < 25)
                    {
                        GetComponent<AudioSource>().volume = Random.Range(0.6f, 1.0f);
                        GetComponent<AudioSource>().pitch = Random.Range(0.95f, 1.0f);
                        GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        GetComponent<AudioSource>().Pause();
                    }
                }
                else
                {
                    GetComponent<AudioSource>().Pause();
                }
            }
            timeToGo = Time.fixedTime + Random.Range(3.0f, 5.0f);
        }
    }

}
