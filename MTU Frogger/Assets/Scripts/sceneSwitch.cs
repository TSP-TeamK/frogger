using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator timer()
    {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene(0);
    }
}
