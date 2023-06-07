using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text TimeText;
    
    float surviveTime;
    bool isGameover;

    public colliderBOX colliderBoxScript;
    public GameObject clearText;

    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;
        isGameover = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameover)
        {
            surviveTime += Time.deltaTime;
            TimeText.text = "Time : " + surviveTime.ToString("F2");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("GameScene");
            }
        }

        GameObject bossObject = GameObject.FindGameObjectWithTag("Boss");
        

        if (bossObject == null)
        {
            ShowClearText();
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("GameScene");
            }
        }

    }
    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);
    }
    private void ShowClearText()
    {

        clearText.gameObject.SetActive(true);
    }
}
