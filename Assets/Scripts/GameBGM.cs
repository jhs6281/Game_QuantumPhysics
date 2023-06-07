using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameBGM : MonoBehaviour
{
    private static GameBGM instance;
    public AudioClip bgmClip;
    private AudioSource audioSource;
    private void Awake()
    {

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.loop = true;

        PlayBGM();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            RepeatBGM();
        }
    }

    void PlayBGM()
    {
        audioSource.Play();
    }

    void RepeatBGM()
    {
        audioSource.time = 0f;
        audioSource.Play();
    }
}







