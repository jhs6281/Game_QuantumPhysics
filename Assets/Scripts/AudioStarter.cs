using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AudioStarter : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        MuteAudio();
    }

    public void MuteAudio()
    {
        // 비디오 플레이어의 오디오를 음소거
        videoPlayer.SetDirectAudioMute(0, true);
    }

    public void UnmuteAudio()
    {
        // 비디오 플레이어의 오디오 음소거 해제
        videoPlayer.SetDirectAudioMute(0, false);
    }

    public void SetVolume(float volume)
    {
        // 비디오 플레이어의 오디오 볼륨 설정
        videoPlayer.SetDirectAudioVolume(0, volume);
    }
}
