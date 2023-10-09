using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Adjustable speed value in the Inspector

    // FixedUpdate is used for physics-related updates
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D or left/right arrow keys
        float verticalInput = Input.GetAxis("Vertical");     // W/S or up/down arrow keys

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.fixedDeltaTime;

        // Apply the movement to the player's position
        transform.Translate(movement);
    }

    // Update is called once per frame
    void Update()
    {
        // You can add other non-physics-related updates here if needed
    }
}
