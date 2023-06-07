using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class colliderBOX : MonoBehaviour
{
    public ParticleSystem targetExplosion;
    public int Hp = 1;
    

    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "Ball")
        {
            Hp--;

            if (Hp <= 0)
            {
                ParticleSystem fire = Instantiate(targetExplosion, transform.position, Quaternion.identity);

                fire.Play();

                Destroy(gameObject);
                Destroy(fire.gameObject, 2.0f);
                
            }
        }
    }



}

