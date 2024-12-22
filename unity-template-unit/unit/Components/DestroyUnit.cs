/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class DestroyUnit : MonoBehaviour, IComponent, IDeleted
{
    /**
     * 
     */
    public void OnDeleted() { Destroy(gameObject); }
}
