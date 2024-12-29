/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/**
 * 
 */
public class LoadSceneOnSubmit : MonoBehaviour
{
	public string scene; //

	/**
	 * 
	 */
	void OnButtonSubmit() => SceneManager.LoadScene(scene);
}
