/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class ResourceAsset<T> : MonoBehaviour where T : Object
{
    [HideInInspector] public T      resource; //
                      public string path;     //

    /**
	 * 
	 */
    void Awake() { resource = Resources.Load<T>(path); }
}
