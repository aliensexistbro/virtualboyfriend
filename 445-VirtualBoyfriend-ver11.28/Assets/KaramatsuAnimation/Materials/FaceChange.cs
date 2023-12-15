using System.Collections;
using UnityEngine;

public class FaceChange : MonoBehaviour
{
    public Material idleFace;
    public Material[] talkMaterials;
    public Material kissMaterials;
    public bool isKiss = false;
    public bool isTalk = false;
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

    IEnumerator SwitchMaterialsCoroutine()
    {
        int materialIndex = 0;

        while (true)
        {
            Material[] currentMaterials;

            // Check the scenario and set the appropriate material array
            if (isKiss)
            {
                currentMaterials = new Material[] { kissMaterials };
            }
            else if (isTalk)
            {
                currentMaterials = talkMaterials;
            }
            else
            {
                currentMaterials = new Material[] { idleFace };
            }

            rend.material = currentMaterials[materialIndex];

            materialIndex = (materialIndex + 1) % currentMaterials.Length;

            yield return new WaitForSeconds(switchInterval);
        }
    }
}