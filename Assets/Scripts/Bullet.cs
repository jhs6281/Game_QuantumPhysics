using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody bulletRB = GetComponent<Rigidbody>();
        bulletRB.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerComtroller playerCtr = other.GetComponent<PlayerComtroller>();

            if(playerCtr != null )
            {
                playerCtr.Die();
            }
        }
    }
}
