using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    public float forceSpeed = 25f;
    public float reflectSpeed = 5f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Shooter")
        {
            Vector3 newVelocity = new Vector3(reflectSpeed * Mathf.Sign(rb.velocity.x), rb.velocity.y, forceSpeed * Mathf.Sign(rb.velocity.z));
            rb.velocity = newVelocity;
        }
    }
}
