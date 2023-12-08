using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorKnocker : MonoBehaviour
{
    public Animator animator;
    public bool doorOpen = false;
    public AudioSource door;
    public AudioSource doorOpening;
    int knocks = 0;

void OnTriggerEnter(Collider other)
    {
        Debug.Log("object entered trigger");
        knocks += 1;
        door.Play();

        if ((knocks >= 3) && !doorOpen)
        {
            doorOpen = true;
            animator.SetTrigger("knock");
            doorOpening.Play();
        }
    }

}
