using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ImageChanger : MonoBehaviour
{
    Image Husky;
    public Sprite husky1;
    public Sprite husky2;
    public Sprite husky3;
    public Sprite husky4;
    public Sprite husky5;
    private int level;
    // Start is called before the first frame update
    void Start()
    {
        Husky = GetComponent<Image>();
        level = GlobalVariables.level;

        if (level == 1)
            Husky.sprite = husky1;
        else if (level == 2)
            Husky.sprite = husky2;
        else if (level == 3)
            Husky.sprite = husky3;
        else if (level == 4)
            Husky.sprite = husky4;
        else //(level == 5)
            Husky.sprite = husky5;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void nextScene()
    {
        int scene = 0;
        if (level == 1)
            scene = 6;
        else if (level == 2)
            scene = 7;
        else if (level == 3)
            scene = 8;
        else if (level == 4)
            scene = 9;
        SceneManager.LoadScene(scene);
    }


}
