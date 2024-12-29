/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class PhysicsLayer : MonoBehaviour, IComponent, ICreated<PrefData>
{
    public string physicsLayer; //

    /**
     * 
     */
    public void OnCreated(PrefData pd) { gameObject.layer = LayerMask.NameToLayer(physicsLayer); gameObject.tag = physicsLayer; }
}
