/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public abstract class ResourceAssets<T> : MonoBehaviour where T : Object
{
    public T[]    resource { get; private set; } //
    public string path;                          //

    /**
	 * 
	 */
    void Awake() { resource = Resources.LoadAll<T>(path); }
}
