using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleController : MonoBehaviour
{
    private bool b_CanHit = true;
    private float f_ShuttleSpeed;

    private void Start()
    {
        f_ShuttleSpeed = Random.Range(0.25f, 0.75f);
    }

    void Update()
    {
        // Keep moving on Y axis (towards calling planet, angle is determined at spawn time)
        transform.Translate(Vector2.up * f_ShuttleSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            if (b_CanHit)
            {
                // destroy the projectile
                Destroy(other.gameObject);

                // set alpha to half on all child components of shuttle prefab
                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).transform.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
                }

                // flip the shuttle 180deg so that it returns to Earth
                transform.localRotation *= Quaternion.Euler(0, 0, 180);
                
                // make sure we can no longer flip it
                b_CanHit = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // destroy the shuttle once it arrives at Earth
        if (other.gameObject.CompareTag("Earth") && transform.position.x < 0 && !b_CanHit)
        {
            Destroy(this.gameObject);
        }
    }
}
