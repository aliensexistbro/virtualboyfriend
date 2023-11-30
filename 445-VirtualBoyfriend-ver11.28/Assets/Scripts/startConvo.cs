using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class startConvo : MonoBehaviour
{
    [SerializeField] private NPCConversation myConvo;
    // Start is called before the first frame update
    public void Start(){
        ConversationManager.Instance.StartConversation(myConvo);
    }
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            
            ConversationManager.Instance.StartConversation(myConvo);
            
        }
    }
}
