using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edibleCookie : MonoBehaviour
{
    public GameObject cookie;
    public AudioSource eatsfx;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cookie"))
        {
            eatsfx.Play();
            Debug.Log("cookie entered trigger");
            Destroy(cookie);
        }
    }
}
