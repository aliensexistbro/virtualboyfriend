using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscript : MonoBehaviour
{
    public SceneLoader sceneload;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("object entered trigger");

        sceneload.LoadScene();

    }
}
