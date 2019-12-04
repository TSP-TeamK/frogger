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
	StartCoroutine(ExampleCoroutine(5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

IEnumerator ExampleCoroutine(float waitTime)
    {
	while (true) {
      	  	//yield on a new YieldInstruction that waits for 5 seconds.
        	yield return new WaitForSeconds(waitTime);
		if (GlobalVariables.L3light) {//light is on
			GlobalVariables.L3light = false;
		}
		else {//light is off
			GlobalVariables.L3light = true;
		}
	}
    }

}
