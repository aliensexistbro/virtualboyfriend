using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;
    public Animator transition;
    public float transitionTime = 1f;
    bool loadingStarted = false;
    float secondsLeft = 0;
    // Update is called once per frame
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

    public void LoadScene()
    {
        StartCoroutine(FadeScene(sceneName));
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
