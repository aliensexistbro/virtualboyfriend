using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DialogueEditor;
public class SceneLoader : MonoBehaviour
{
    public string sceneName;
    public Animator transition;
    public float transitionTime = 1f;
    bool loadingStarted = false;
    private bool sceneReady=false;
    float secondsLeft = 0;
    // Update is called once per frame
    public GameObject destroy1;
    public GameObject destroy2;
    public GameObject destroy3;

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    IEnumerator FadeScene(string sceneName)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
        Debug.Log("playing");
    }
    public void Update(){
         if(UIConversationButton.Instance!=null)
            sceneReady=ConversationManager.Instance.GetBool("SceneChangeReady");

        if(sceneReady){
            Debug.Log(sceneReady);
            sceneReady=false;
            TimeLoad(3f);
        }
    }
    public void LoadScene()
    {
        StartCoroutine(FadeScene(sceneName));
        Destroy(destroy1);
        Destroy(destroy2);
        Destroy(destroy3);
        Debug.Log("playing");
    }

    public void TimeLoad(float seconds)
    {
        StartCoroutine(DelayLoadLevel(seconds));
    }

    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        LoadScene();
    }
}
