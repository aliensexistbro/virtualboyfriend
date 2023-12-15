using System.Collections;
using UnityEngine;
using DialogueEditor;
public class FaceChange : MonoBehaviour
{
    public Material idleFace;
    public Material[] talkMaterials;
    public Material kissMaterials;
    public bool isKiss = false;
    public bool isTalk = false;
    public AudioSource dialogueAudio;
    public Renderer rend;
    public float switchInterval = 1f;

    void Start()
    {
        rend = GetComponent<Renderer>();

        if (rend == null)
        {
            Debug.LogError("Renderer component not found on the GameObject.");
            return;
        }

        // Start the coroutine to switch materials based on the scenario
        StartCoroutine(SwitchMaterialsCoroutine());
    }
    void Update(){
        if(dialogueAudio.isPlaying)
            isTalk=true;
        else 
            isTalk=false;

        if(ConversationManager.Instance.GetBool("kiss"))
            isKiss=true;        
    }

    IEnumerator SwitchMaterialsCoroutine()
    {
        int materialIndex = 0;
        float IEinterval=switchInterval;
        while (true)
        {   
            
            Material[] currentMaterials;

            // Check the scenario and set the appropriate material array
            if (isKiss)
            {
                currentMaterials = new Material[] { kissMaterials };
                materialIndex=0;
                Debug.Log("Kissing");
                ConversationManager.Instance.SetBool("kiss",false);
                IEinterval=1.7f;
                isKiss=false;
            }
            else if (isTalk)
            {   
                Debug.Log("talking");
                currentMaterials = talkMaterials;
            }
            else
            {
                currentMaterials = new Material[] { idleFace };
                materialIndex=0;
            }

            rend.material = currentMaterials[materialIndex];

            materialIndex = (materialIndex + 1) % currentMaterials.Length;

            yield return new WaitForSeconds(IEinterval);
        }
    }
}