using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Create a time variable, starting at 2 so the player can instantly send a dog,
    // this will make sense later
    private float time = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // Assign time variable to Time.deltaTime
        time += Time.deltaTime;

        // If spacebar is pressed AND time passed is more or equal to 2 seconds, 
        // send dog and reset timer to 0

        if (Input.GetKeyDown(KeyCode.Space) && (time >= 2f))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time = 0f;
        }

    }
}
