using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    FrogMovement movement;
 
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<FrogMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.playerMoving == true && movement.moveSpeed > 0.5f
            && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.5f, 1);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.1f);
            GetComponent<AudioSource>().Play();
        }
    }
}
