using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private float rotationSpeed = 90f;
    private float verticalMoveSpeed = 2f;
    
    public GameObject earthObj;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // handle rotation around Earth
        transform.RotateAround(earthObj.transform.position, new Vector3(0, 0, horizontalInput), rotationSpeed * Time.deltaTime);

        // handle vertical movement
        transform.Translate(Vector2.up * verticalInput * verticalMoveSpeed * Time.deltaTime);
    }
}
