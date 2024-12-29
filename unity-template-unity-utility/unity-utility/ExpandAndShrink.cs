/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class ExpandAndShrink : MonoBehaviour
{
	public float speed;		 //
	public float expandTime; //
	public float shrinkTime; //

	/**
     * 
     */
	void Update()
	{
		if ((expandTime -= Time.deltaTime) > 0) { transform.localScale += speed * Time.deltaTime * Vector3.one; return; }
		if ((shrinkTime -= Time.deltaTime) > 0) { transform.localScale -= speed * Time.deltaTime * Vector3.one; return; }
	}
}
