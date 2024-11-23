using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopupManager : Singleton<PopupManager>
{
    public TextMeshPro popupPrefab; //

    /**
     * 
     */
    public void CreatePopup(Vector2 position, string message)
    {
        var popup = Instantiate(popupPrefab, transform);

        popup.transform.position = position;
        popup.text = message;
    }
}
