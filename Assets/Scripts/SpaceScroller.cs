using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceScroller : MonoBehaviour
{
    public Material mat;

    void Update()
    {
        mat.mainTextureOffset = new Vector2(-Time.timeSinceLevelLoad/5, 0);
    }
}
