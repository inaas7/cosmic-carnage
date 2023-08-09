using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid_moving : MonoBehaviour
 {   
    public float speed = 5.0f;
    public bool moveRight = true; // Set this in the Inspector to choose the initial direction

    // Update is called once per frame
    void Update()
    {
        // Calculate the movement direction
        Vector3 movementDirection = moveRight ? Vector3.right : Vector3.left;

        // Move the object based on the specified direction and speed
        transform.Translate(movementDirection * speed * Time.deltaTime);

        // Check if the object is outside the camera's view
        if (!IsVisible())
        {
            Destroy(gameObject);
        }
    }

    bool IsVisible()
    {
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);
        return (viewportPosition.x > 0 && viewportPosition.x < 1);
    }
}