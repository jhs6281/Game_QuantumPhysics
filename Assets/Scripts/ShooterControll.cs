using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using Unity.VisualScripting;
using UnityEngine;

public class ShooterControll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision coll)
    {
            if (coll.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRigidbody = coll.gameObject.GetComponent<Rigidbody>();
            ballRigidbody.isKinematic = false;
            StartCoroutine(kinematicSwitch());
        }
    }
    private IEnumerator kinematicSwitch()
    {
        GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");
        foreach (GameObject ball in balls)
        {
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            yield return new WaitForSeconds(2f);
            ballRigidbody.isKinematic = true;
        }
    }
}
