using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using System.Collections;

public class PlayerAnimatorController : MonoBehaviour
{
    public bool isIdle = false;
    public Animator playerController;
    // Start is called before the first frame update
    void Start()
    {
        if(isIdle)
        {
            playerController.SetTrigger("idle");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
