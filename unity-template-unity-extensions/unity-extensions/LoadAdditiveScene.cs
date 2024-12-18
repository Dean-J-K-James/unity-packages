/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * 
 */
public class LoadAdditiveScene : MonoBehaviour
{
    public string sceneName; //

    /**
     * 
     */
    void Awake() => SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
}
