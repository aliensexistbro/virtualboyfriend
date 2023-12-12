using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class edibleCookie : MonoBehaviour
{
    public GameObject cookie;
    public AudioSource eatsfx;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cookie"))
        {
            if (UIConversationButton.Instance != null) 
                ConversationManager.Instance.SetBool("CookieEaten", true);
            eatsfx.Play();
            Debug.Log("cookie entered trigger");
            Destroy(cookie);
                
        }
    }
}
