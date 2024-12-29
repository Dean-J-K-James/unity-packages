/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class DecelerateToOffset : MonoBehaviour
{
	public Vector3 offset; //
	public float   speed;  //

	/**
     * 
     */
	void Update() { if ((speed -= Time.deltaTime) > 0) { transform.position = Vector2.MoveTowards(transform.position, transform.position + offset, speed * Time.deltaTime); } }
}
