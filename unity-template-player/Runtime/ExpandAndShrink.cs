using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ExpandAndShrink : MonoBehaviour
{
    public float speed;
    public float growTime;
    public float shrinkTime;

    // Update is called once per frame
    void Update()
    {
        if ((growTime -= Time.deltaTime) > 0)
        {
            transform.localScale += Vector3.one * speed * Time.deltaTime;
            return;
        }

        if ((shrinkTime -= Time.deltaTime) > 0)
        {
            transform.localScale -= Vector3.one * speed * Time.deltaTime;
            return;
        }
    }
}
