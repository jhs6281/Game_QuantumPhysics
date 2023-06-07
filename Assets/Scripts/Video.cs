using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Video : MonoBehaviour
{
    public GameObject myVideo;
    public VideoPlayer videoClip;

    public void Start()
    {
        myVideo.SetActive(false);
        
    }
    public void OnplayVideo()
    {
        myVideo.SetActive(true);
        videoClip.Play();
    }
    
}
