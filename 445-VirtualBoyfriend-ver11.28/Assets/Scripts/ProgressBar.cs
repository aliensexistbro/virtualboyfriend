using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DialogueEditor;
public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private bool affectionUp;
    private static float affectionValue;
    private bool increased=false;
    private float fillProgress = 0.1f;
    public float defaultProgress;
    public float target = 0;
    // Start is called before the first frame update
    void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value=affectionValue;
    }
    private void Hide()
    {
        this.gameObject.SetActive(false);
    }
    private void Show()
    {
        this.gameObject.SetActive(true);
    }
    private void Start()
    {
        IncreaseBar(defaultProgress);
    }

    private void Update()
    {   
        affectionValue=slider.value;
        affectionUp=ConversationManager.Instance.GetBool("affectionIncrease");
        //Debug.Log(slider.value);
        if(affectionUp&&!increased){
            Debug.Log("affection up");
            IncreaseBar(0.2f);
            affectionUp=false;
            increased=true;
        }
        if (slider.value < target)
            slider.value += fillProgress * Time.deltaTime;
    }
    void IncreaseBar(float progress)
    {
        target += slider.value + progress;
    }
}
