using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeOverTime : MonoBehaviour
{
    public TextMeshPro text; //
    public float delay;
    public float fadeSpeed;

    // Update is called once per frame
    void Update()
    {
        if ((delay -= Time.deltaTime) <= 0)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - Time.deltaTime * fadeSpeed);
        }
    }
}
