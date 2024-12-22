/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class InvokeGlobalChangedOnTick : MonoBehaviour, IComponent, ITickerd
{
    /**
     * 
     */
    public void OnTickerd() { this.GlobalChanged(); }
}
