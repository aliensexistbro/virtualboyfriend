using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaramatsuAnimatorController : MonoBehaviour
{
    public string triggerName;
    public Animator karaController;
    // Start is called before the first frame update
    void Start()
    {
        karaController.SetTrigger(triggerName);
    }

    void ChangeAnimation(string triggerN)
    {
        karaController.SetTrigger(triggerN);
    }    
}
