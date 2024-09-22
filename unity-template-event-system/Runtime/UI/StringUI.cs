/********************************************************/
/* Dean James * Pangean Flying Cactus * Project Sandbox */
/********************************************************/

using TMPro;
using UnityEngine;

/**
 * 
 */
public class StringUI : MonoBehaviour
{
	public TextMeshProUGUI text; //

	/**
     * 
     */
	public void Change(string val) { text.text = val; }
}
