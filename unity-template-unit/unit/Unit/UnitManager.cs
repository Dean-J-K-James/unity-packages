/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class UnitManager : Singleton<UnitManager>
{
    /**
     * 
     */
    public void Create(string k, float x, float y)
    {
        var i = Instantiate(Asset.INSTANCE.Get<Unit>(k), transform);

        i.name = k;
        i.transform.position = new Vector2(x, y);
        i.gameObject.SetActive(true);

        i.InvokeCreated();
        i.InvokeChanged();
    }
}
