using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{

    private Animator platformAnim;

    // Start is called before the first frame update
    void Start()
    {
        // Makes reference to animator, allowing me to trigger it later.

        platformAnim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If player model collides with platform, platform animation triggers.

        if (collision.gameObject.CompareTag("Player")) 
        {
            platformAnim.SetTrigger("PlayerOnPlatform");
            Debug.Log("Player Has Trigger Animated Platform");
        }
    }

}
