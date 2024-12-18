/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class DontDestroyOnLoad : MonoBehaviour
{
    /**
     * 
     */
    void Awake() => DontDestroyOnLoad(gameObject);
}
