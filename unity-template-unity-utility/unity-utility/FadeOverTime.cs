/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using TMPro;
using UnityEngine;

/**
 * 
 */
public class FadeOverTime : MonoBehaviour
{
	public TextMeshPro text;	  //
	public float	   delay;	  //
	public float	   fadeSpeed; //

	/**
     * 
     */
	void Update() { if ((delay -= Time.deltaTime) <= 0) { text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - Time.deltaTime * fadeSpeed); } }
}
