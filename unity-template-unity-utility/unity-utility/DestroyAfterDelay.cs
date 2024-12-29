/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class DestroyAfterDelay : MonoBehaviour
{
	public float delay; //

	/**
     * 
     */
	void Update() { if ((delay -= Time.deltaTime) <= 0) { Destroy(gameObject); } }
}
