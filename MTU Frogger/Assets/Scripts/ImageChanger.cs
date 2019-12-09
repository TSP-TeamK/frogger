using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ImageChanger : MonoBehaviour
{
    Image Husky;
    private Sprite husky1;
    private Sprite husky2;
    private Sprite husky3;
    private Sprite husky4;
    private Sprite husky5;
    private int level = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        //Husky = Instantiate<Image>(Resources.Load<Image>("Pictures/Image"));
        husky1 = Instantiate<Sprite>(Resources.Load<Sprite>("Pictures/HappyHusky1"));
        husky2 = Instantiate<Sprite>(Resources.Load<Sprite>("Pictures/HappyHusky2"));
        husky3 = Instantiate<Sprite>(Resources.Load<Sprite>("Pictures/HappyHusky3"));
        husky4 = Instantiate<Sprite>(Resources.Load<Sprite>("Pictures/HappyHusky4"));
        husky5 = Instantiate<Sprite>(Resources.Load<Sprite>("Pictures/HappyHusky5"));
        level = GlobalVariables.level;

        //if (husky1 == null) Debug.Log("husky1 null");
        //if (Husky == null) Debug.Log("Husky is null");
        //if (Husky.sprite == null) Debug.Log("sprite is null");
        //if (level == 0) Debug.Log("level is null");
        if (level == 1)
        {
            Husky.sprite = husky1;
        }
        else if (level == 2)
            Husky.sprite = husky2;
        else if (level == 3)
            Husky.sprite = husky3;
        else if (level == 4)
            Husky.sprite = husky4;
        else //(level == 5)
            Husky.sprite = husky5;
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
