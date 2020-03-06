using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceChange : MonoBehaviour
{
    public int Faceset = 0;
    public float distance = 0.25f;
    public float startx = 0.26f;
    public float starty = 0.21f;
    public Material droneface;
    void Update()
    {
        droneface.mainTextureOffset = new Vector2 (startx+Faceset*distance, starty);
    }
}
