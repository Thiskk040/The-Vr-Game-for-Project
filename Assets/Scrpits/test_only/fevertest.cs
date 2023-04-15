using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fevertest : MonoBehaviour
{
    public Material red, blue;
    MeshRenderer meshRenderer;
    Material oldMaterial;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        oldMaterial = meshRenderer.material;

    }

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.GetInstant().fever)
        {
            meshRenderer.material = red;
        }
        else
        {
            meshRenderer.material = blue;
        }

    }
}
