/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using UnityEngine;
using UnityEngine.UI;

/**
 * 
 */
public class RandomImageFromResources : MonoBehaviour
{
	public string path; //

	/**
	 * 
	 */
	void Awake()
	{
		GetComponent<Image>().sprite = Resources.LoadAll<Sprite>(path)[Random.Range(0, Resources.LoadAll<Sprite>(path).Length)];
	}
}