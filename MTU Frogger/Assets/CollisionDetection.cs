using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D characterRigBod;
    void OnCollisionEnter(Collision collision)
    {
        characterRigBod = GetComponent<Rigidbody2D>();
        Vector2 vec = new Vector2(0.0f, 0.0f);
        characterRigBod.position = vec;
        Debug.Log("Collision");
    }
}
