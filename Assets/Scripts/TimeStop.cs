using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Windows.WebCam.VideoCapture;


public class TimeStop : MonoBehaviour
{
    private Rigidbody shooterRigidbody;
    private GameObject shooter;
    private GameObject player;
    bool UsedSkill = false;
    bool isShooterKinematic = false;
    private Video video;
    private AudioStarter audioStarter;
    

    private void Start()
    {
        
        GameObject audioStarterObject = GameObject.Find("Ugokuna");
        audioStarter = audioStarterObject.GetComponent<AudioStarter>();
        video = GetComponent<Video>();
        player = GameObject.FindWithTag("Player");
        shooter = GameObject.FindWithTag("Shooter");
        shooterRigidbody = shooter.GetComponent<Rigidbody>();
    }
    private void Update()
    { 
        if (!UsedSkill)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                audioStarter.UnmuteAudio();
                video.OnplayVideo();
                StartCoroutine(InputSkillKey());
                
            }
        }

    }
    private IEnumerator InputSkillKey()
    {
        
        yield return new WaitForSecondsRealtime(2.5f);
        ActiveSkill();
        video.myVideo.SetActive(false);
        yield return new WaitForSecondsRealtime(3f);
        isShooterKinematic = false;


    }
    private void ActiveSkill()
    {
        Rigidbody[] allRigidbodies = FindObjectsOfType<Rigidbody>();
        isShooterKinematic = true;
        foreach (Rigidbody rb in allRigidbodies)
        {
            if (!UsedSkill)
            {
                if (rb.gameObject != player)
                {
                    rb.velocity = Vector3.zero;
                    rb.angularVelocity = Vector3.zero;
                }
            }
            UsedSkill = true;
        }
    }
    private void FixedUpdate()
    {
        if (isShooterKinematic)
        {
            shooterRigidbody.isKinematic = true;
        }
        else if (!isShooterKinematic)
        {
            shooterRigidbody.isKinematic = false;
        }
    }
}
