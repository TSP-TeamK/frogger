using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    private static MusicScript instance = null;
    Object[] myMusic;
    Object[] endMusic;
    public AudioSource audioSource;
    bool end = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);

            DontDestroyOnLoad(transform.gameObject); //lets the music continue across scenes
            myMusic = Resources.LoadAll("Music", typeof(AudioClip));
            audioSource.GetComponent<AudioSource>();
            audioSource.clip = myMusic[0] as AudioClip;

            endMusic = Resources.LoadAll("EndMusic", typeof(AudioClip));
        }

        else Destroy(this.gameObject);
    }

    void Start()
    {
        endMusic = Resources.LoadAll("EndMusic", typeof(AudioClip));
        myMusic = Resources.LoadAll("Music", typeof(AudioClip));
        playRandomMusic();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            playRandomMusic();
        }
        if (end == true && SceneManager.GetActiveScene().buildIndex != 10)
        {
            end = false;
            audioSource.Stop();
            playRandomMusic();
        }
        if (SceneManager.GetActiveScene().buildIndex == 10 && !end) //if we are at the losing screen
        {
            end = true;
            audioSource.clip = endMusic[0] as AudioClip;
            audioSource.Play();
        }
        if (SceneManager.GetActiveScene().buildIndex == 9) //if we are at the losing screen
        {
            audioSource.Stop();
        }

    }

    public void playRandomMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        audioSource.Play();
    }

    void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        playRandomMusic();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void musicSoundLevel()
    {
        GameObject gameObject = GameObject.Find("slider");
        Slider audioSlider = gameObject.GetComponent<Slider>();
        audioSource.volume = audioSlider.value;
        AudioListener.volume = audioSlider.value;
    }
}
