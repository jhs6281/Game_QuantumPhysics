using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GuideButton : MonoBehaviour
{
    
    public GameObject GuideImage;
    private bool isGuideImageActive = false;

    public void OnButtonClick()
    {
        ShowGuideImage();
    }
    private void Start()
    {
        GuideImage.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (isGuideImageActive && Input.anyKeyDown)
        {
            CloseGuideImage();
        }
    }

    public void ShowGuideImage()
    {
        GuideImage.gameObject.SetActive(true);
        isGuideImageActive = true;
    }

    private void CloseGuideImage()
    {
        GuideImage.gameObject.SetActive(false);
        isGuideImageActive = false;
    }

}
