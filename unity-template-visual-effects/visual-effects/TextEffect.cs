using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextEffect : Singleton<TextEffect>
{
    public TextMeshPro popupPrefab; //

    /**
     * 
     */
    public void Create(Vector2 position, string message)
    {
        var popup = Instantiate(popupPrefab, transform);

        popup.transform.position = position;
        popup.text = message;
    }
}
