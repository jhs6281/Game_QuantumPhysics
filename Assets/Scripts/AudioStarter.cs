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
        // ���� �÷��̾��� ������� ���Ұ�
        videoPlayer.SetDirectAudioMute(0, true);
    }

    public void UnmuteAudio()
    {
        // ���� �÷��̾��� ����� ���Ұ� ����
        videoPlayer.SetDirectAudioMute(0, false);
    }

    public void SetVolume(float volume)
    {
        // ���� �÷��̾��� ����� ���� ����
        videoPlayer.SetDirectAudioVolume(0, volume);
    }
}
