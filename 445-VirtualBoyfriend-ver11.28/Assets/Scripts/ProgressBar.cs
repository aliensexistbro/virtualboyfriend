using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    public float fillProgress = 0.05f;
    public float target = 0;
    // Start is called before the first frame update
    void Awake()
    {
        slider = gameObject.GetComponent<Slider>();

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
        IncreaseBar(0.75f);
    }

    private void Update()
    {
        if (slider.value < target)
            slider.value += fillProgress * Time.deltaTime;
    }
    void IncreaseBar(float progress)
    {
        target += slider.value + progress;
    }
}
