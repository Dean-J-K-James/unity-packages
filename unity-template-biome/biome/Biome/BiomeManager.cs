/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class BiomeManager : MonoBehaviour
{
	/**
     * 
     */
	void Start()
	{
		string biome = PlayerPrefs.GetString("level", "dungeon");

		var b = Instantiate(Asset.INSTANCE.Get<Biome>(biome), transform);
		b.gameObject.SetActive(true);
		b.InvokeCreated();
	}
}
