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
            if(ConversationManager.Instance.GetBool("SceneStart")){
                ChangeAnimation("welcome");
                cookies.SetActive(true);
            }
         }
    }

    void ChangeAnimation(string triggerN)
    {
        karaController.SetTrigger(triggerN);
    }    
}
