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
    public Image    image;   //
    public Sprite[] sprites; //

    /**
	 * 
	 */
    void Start() { image.sprite = sprites[Random.Range(0, sprites.Length)]; }
}
