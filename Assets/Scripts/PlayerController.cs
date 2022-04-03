using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private float projectileSpeed = .5f;
    private float rotationSpeed = 90f;  
    private float verticalMoveSpeed = 2f;

    public GameObject bulletObj;
    public GameObject earthObj;

    private void Update()
    {
        Movement();
        Fire();
    }

    private void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // handle rotation around Earth
        transform.RotateAround(earthObj.transform.position, new Vector3(0, 0, horizontalInput), rotationSpeed * Time.deltaTime);

        // handle vertical movement
        transform.Translate(Vector2.up * verticalInput * verticalMoveSpeed * Time.deltaTime);
    }

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiante and store it as temporal Rigidbody2D
            Rigidbody2D projectileRbody = Instantiate(bulletObj, transform.position, transform.rotation).GetComponent<Rigidbody2D>();
            // AddForce to the stored Rigidbody2D
            projectileRbody.AddForce(-transform.position * projectileSpeed, ForceMode2D.Impulse);
        }
    }
}
