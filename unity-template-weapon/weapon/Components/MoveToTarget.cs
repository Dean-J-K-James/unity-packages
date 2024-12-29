/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class MoveToTarget : MonoBehaviour, IComponent
{
	public Vector2 target; //
	public float speed; //

	/**
     * 
     */
	void Update()
	{
		if (Vector2.Distance(transform.position, target) <= 0.1f)
		{
			Destroy(gameObject);
		}

		transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}
}
