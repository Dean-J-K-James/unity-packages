/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class Asset : Singleton<Asset>
{
    /**
	 * 
	 */
    public T Get<T>(string k) where T : MonoBehaviour { return transform.Find(k).GetComponent<T>(); }
}
