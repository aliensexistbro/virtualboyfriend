using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class KaramatsuAnimatorController : MonoBehaviour
{
    public string triggerName;
    public Animator karaController;
    public GameObject cookies;
    // Start is called before the first frame update
    void Start()
    {
        if(triggerName == "none")
        {

        }
        else
        {
            karaController.SetTrigger(triggerName);
        }
    }

    void Update(){
         if(UIConversationButton.Instance!=null){
            Debug.Log("welcome animation");
            if(ConversationManager.Instance.GetBool("SceneStart")){
                ChangeAnimation("welcome");
                cookies.SetActive(true);
            }
         }

        if (ConversationManager.Instance.GetBool("laying_down"))
        {
            ChangeAnimation("laying_down");
        }
    }

    void ChangeAnimation(string triggerN)
    {
        karaController.SetTrigger(triggerN);
    }    
}
