/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class CustomRigidbody2D : MonoBehaviour, IComponent, ICreated<PrefData>
{
    /**
     * 
     */
    public void OnCreated(PrefData pd)
    {
        gameObject.AddComponent<Rigidbody2D>().gravityScale = 0;
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

        gameObject.AddComponent<CircleCollider2D>().radius = 0.4f;
    }
}
