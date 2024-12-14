/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.UI;

/**
 * 
 */
public class RandomImageSelector : MonoBehaviour
{
    public SpriteResourceAssets sprites; //
    public Image                image;   //

    /**
	 * 
	 */
    void Start() { image.sprite = sprites.resource[Random.Range(0, sprites.resource.Length)]; }
}
