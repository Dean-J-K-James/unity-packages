using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    public float delay;

    void Update()
    {
        if ((delay -= Time.deltaTime) <= 0)
        {
            Destroy(gameObject);
        }
    }
}
