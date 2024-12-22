/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class Ticker : MonoBehaviour
{
    float tick = 1f; //

    /**
     * 
     */
    void Update() { if ((tick -= Time.deltaTime) <= 0f) { tick = 1f; foreach (Transform c in transform) { c.GetComponent<MonoBehaviour>().InvokeTickerd(); } } }
}
