using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    private Rigidbody rb;
    private MonoBehaviour[] scriptsToPause;

    private bool isPaused = false;

    void Start()
    {
        // Example: Get references to components
        rb = GetComponent<Rigidbody>();

        // Example: Get references to MonoBehaviours (scripts) on the GameObject
        scriptsToPause = GetComponents<MonoBehaviour>();
    }

    void Update()
    {
       // if (timestop)  // You can change the key to pause/resume the object
     //   {
      //      TogglePause();
       // }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            PauseObject();
        }
        else
        {
            ResumeObject();
        }
    }

    void PauseObject()
    {
        // Example: Pause Rigidbody
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
        }

        // Example: Disable scripts
        if (scriptsToPause != null)
        {
            foreach (MonoBehaviour script in scriptsToPause)
            {
                script.enabled = false;
            }
        }

        // Implement any additional pause logic specific to your GameObject
    }

    void ResumeObject()
    {
        // Example: Resume Rigidbody
        if (rb != null)
        {
            rb.isKinematic = false;
        }

        // Example: Enable scripts
        if (scriptsToPause != null)
        {
            foreach (MonoBehaviour script in scriptsToPause)
            {
                script.enabled = true;
            }
        }

        // Implement any additional resume logic specific to your GameObject
    }
}
