using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subwayScene : MonoBehaviour
{
    public SceneLoader load;
    public float loading_sec = 20f;
    // Start is called before the first frame update
    void Start()
    {
        load.TimeLoad(loading_sec);
    }
}
