/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

/**
 * 
 */
public struct GameObjectMetaData
{
    public string slug;      //
    public string type;      //
    public string variation; //

    /**
     * 
     */
    public GameObjectMetaData(string name)
    {
        slug = name[..(name.IndexOf('.'))];

        variation = name.LastIndexOf('_') != -1 ? name[(name.LastIndexOf('_') + 1)..] : "";

        type = name;
        type = type.Replace(slug + ".", "");
        type = type.Replace("_" + variation, "");
    }
}
