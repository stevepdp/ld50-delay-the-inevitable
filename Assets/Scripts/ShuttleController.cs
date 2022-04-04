using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuttleController : MonoBehaviour
{
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
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
