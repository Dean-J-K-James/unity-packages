/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class BiomeManager : MonoBehaviour
{
    public string biome; //

    /**
     * 
     */
    void Start() { var b = Instantiate(Asset.INSTANCE.Get<Biome>(biome), transform); b.gameObject.SetActive(true); b.InvokeCreated(); }
}
