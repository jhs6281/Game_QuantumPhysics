using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComtroller : MonoBehaviour
{
    Rigidbody playerRb;
    public float speed = 4f;
    public float jumpForce = 5f;
   


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }


    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        Vector3 newVelocity = new Vector3(xSpeed, playerRb.velocity.y, zSpeed);
        playerRb.velocity = newVelocity;

        if (transform.position.y < -25f)
        {
            gameManager gameManager = FindObjectOfType<gameManager>();
            gameManager.EndGame();

        }
    }
    private void Jump()
    {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    public void Die()
    {
        gameObject.SetActive(false);

        gameManager gameManager = FindObjectOfType<gameManager>();
        gameManager.EndGame();

    }

}
