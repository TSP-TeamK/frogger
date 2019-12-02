using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Footsteps : MonoBehaviour
{
    FrogMovement movement;
    public GameObject soundToggle;
    Toggle toggle;

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
            GetComponent<AudioSource>().volume = Random.Range(0.5f, 1);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
            GetComponent<AudioSource>().Play();
        }
        //if toggle setting is off, mute sound effect
        if (PlayerPrefs.GetInt("ToggleSetting") == 0)
        {
            GetComponent<AudioSource>().volume = 0;
            GetComponent<AudioSource>().pitch = 0;
        }
    }

}
