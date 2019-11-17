using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MusicScript : MonoBehaviour
{
    // Start is called before the first frame update
    private static MusicScript instance = null;
    Object[] myMusic;
    public AudioSource audioSource;

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
        }

        else Destroy(this.gameObject);
    }

    void Start()
    {
        myMusic = Resources.LoadAll("Music", typeof(AudioClip));
        playRandomMusic();
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            playRandomMusic();
        }
    }

    void playRandomMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        audioSource.Play();
    }

    public void PlayMusic()
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
