/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class Updater : MonoBehaviour
{
    /**
     * 
     */
    void Update() { foreach (Transform c in transform) { c.GetComponent<MonoBehaviour>().InvokeUpdated(); } }
}
