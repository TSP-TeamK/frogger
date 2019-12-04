using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GlobalVariables.negXvalue = -12.5f;
	GlobalVariables.Xvalue = 12.5f;
	GlobalVariables.negYvalue = -5f;
	GlobalVariables.respawnX = 3f;
	GlobalVariables.respawnY = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
