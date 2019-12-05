using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Footsteps : MonoBehaviour
{
    FrogMovement movement;
    public GameObject soundToggle;
    Toggle toggle;
    public AudioSource footstep;
    public AudioSource hit;
    public AudioSource coin;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<FrogMovement>();
        toggle = soundToggle.GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        //if player is moving and toggle setting is on
        //play footstep sound effect
        if (movement.playerMoving == true && movement.moveSpeed > 0.5f
            && GetComponent<AudioSource>().isPlaying == false && PlayerPrefs.GetInt("ToggleSetting") == 1)
        {
            footstep.volume = Random.Range(0.1f, 1.0f);
            footstep.pitch = Random.Range(1.2f, 2.2f);
            footstep.Play();
        }

        //if toggle setting is off, mute sound effect
        if (PlayerPrefs.GetInt("ToggleSetting") == 0)
        {
            footstep.volume = 0;
            hit.volume = 0;
        }
    }

    public void playHitSound()
    {
        hit.Play();
    }

    public void playCoinSound()
    {
        coin.Play();
    }
}
