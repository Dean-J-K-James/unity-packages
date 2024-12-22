/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System;
using System.Collections;
using UnityEngine;

/**
 * 
 */
public class LoadJsonToPrefab : MonoBehaviour
{
    public StringUI   state;         //
    public GameObject defaultPrefab; //

    /**
     * 
     */
    IEnumerator Start()
    {
        foreach (var prefab in Resources.LoadAll<TextAsset>("Entity/"))
        {
            CreateTemplate(prefab);
            yield return new WaitForSeconds(0.05f);
        }

        DeletePrefabs();
        yield return null;
        RenamePrefabs();
        yield return null;
        InvokePrefabs();

        UnityEngine.SceneManagement.SceneManager.LoadScene("scn-game");
    }

    /**
     * 
     */
    void CreateTemplate(TextAsset json)
    {
        state.Change("Loading " + JsonUtility.FromJson<JsonObject>(json.text).name);

        CreatePrefabList(json.name.Split('.'));
    }

    /**
     * 
     */
    void CreatePrefabList(string[] names)
    {
        GameObject prefab = defaultPrefab;

        for (int i = 0; i < names.Length; i++)
        {
            prefab = CreateEntity(prefab, string.Join(".", names[0..(i + 1)]));
        }
    }

    /**
     * 
     */
    GameObject CreateEntity(GameObject prefab, string name)
    {
        var obj = Asset.INSTANCE.Get<MonoBehaviour>(name);

        if (obj != null)
        {
            return obj.gameObject;
        }

        return CreateNewEntity(prefab, Resources.Load<TextAsset>("Entity/" + name));
    }

    /**
     * 
     */
    GameObject CreateNewEntity(GameObject prefab, TextAsset json)
    {
        var entity = Instantiate(prefab, transform);
        entity.name = json.name;

        AddComponents(entity, JsonUtility.FromJson<JsonObject>(json.text).components);
        JsonOverwrite(entity, json.text);

        return entity;
    }

    /**
     * 
     */
    void DeletePrefabs()
    {
        foreach (Transform child in Asset.INSTANCE.transform)
            if (child.name.Contains("+") == false)
            {
                Destroy(child.gameObject);
            }
    }

    /**
     * 
     */
    void RenamePrefabs()
    {
        foreach (Transform child in Asset.INSTANCE.transform)
        {
            child.name = child.name.Split('.')[^1].Replace("+", "");
        }
    }

    /**
     * 
     */
    void InvokePrefabs()
    {
        foreach (Transform child in Asset.INSTANCE.transform)
        {
            child.GetComponent<MonoBehaviour>().InvokeCreated(new PrefData());
        }
    }

    /**
     * 
     */
    void AddComponents(GameObject go, string[] components)
    {
        if (components != null)
            foreach (var c in components)
            {
                AddComponentFromType(go, c.ToString());
            }
    }

    /**
     * 
     */
    void JsonOverwrite(GameObject go, string json)
    {
        foreach (var c in go.GetComponents<IComponent>())
        {
            JsonUtility.FromJsonOverwrite(json, c);
        }
    }

    /**
     * 
     */
    public void AddComponentFromType(GameObject go, string type)
    {
        var t = TypeFromString.Get(type);

        if (t != null)
        {
            go.AddComponent(t);
        }
    }
}
