using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class KaramatsuAnimatorController : MonoBehaviour
{
    public string triggerName;
    public Animator karaController;
    public GameObject cookies;
    public GameObject karaModel;
    public GameObject handCollider;
    private bool laydown = true;
    public bool bedTime;

    // Start is called before the first frame update
    void Start()
    {
        if (triggerName == "none")
        {

        }
        else
        {
            karaController.SetTrigger(triggerName);
        }
    }

    void Update(){
         if(bedTime){
                ChangeAnimation("bedtime");
            }

        if(ConversationManager.Instance.IsConversationActive){
            // Debug.Log("welcome animation");
            if(ConversationManager.Instance.GetBool("SceneStart")){
                ChangeAnimation("welcome");
                cookies.SetActive(true);
            }
            if(ConversationManager.Instance.GetBool("voiceLine3")){
                ChangeAnimation("thoughts");
            }
            if(ConversationManager.Instance.GetBool("thankGoodness")){
                ChangeAnimation("thankgoodness");
            }
              if(ConversationManager.Instance.GetBool("dontWorry")){
                ChangeAnimation("worry");
            }
              if(ConversationManager.Instance.GetBool("getInside")){
                ChangeAnimation("getinside");
            }
             if(ConversationManager.Instance.GetBool("sinfulRequest")){
                ChangeAnimation("sinfulrequest");
            }
            if(ConversationManager.Instance.GetBool("handHold")){
                handCollider.SetActive(true);
                ChangeAnimation("handhold1");
            }
            if (ConversationManager.Instance.GetBool("handHold2"))
            {
                handCollider.SetActive(false);
                ChangeAnimation("handhold2");
            }
            if (ConversationManager.Instance.GetBool("kiss")){
                ChangeAnimation("kiss");
            }
              if(ConversationManager.Instance.GetBool("noSinning")){
                ChangeAnimation("no_sinning");
            }
              if(ConversationManager.Instance.GetBool("goodNight")){
                ChangeAnimation("gn");
            }
            
            
            

      

            if (ConversationManager.Instance.GetBool("laying_down") && laydown)
            {
                laydown = false;
                karaModel.transform.Rotate(0f, 90f, 0f);
                karaModel.transform.position = new Vector3(-1.7788f, 0.8409f, -3.1847f);
                ChangeAnimation("laying_down");
            } 
        
        
        }

        





    }

    void ChangeAnimation(string triggerN)
    {
        karaController.SetTrigger(triggerN);
    }    
}
