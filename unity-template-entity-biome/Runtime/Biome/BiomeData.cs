/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

/**
 * 
 */
public class BiomeData : EntityData
{
	public readonly Biome biome; //is this really needed? it can already be used by using GetComponent<Biome>()...

    /**
	 * 
	 */
    public BiomeData(Biome b) : base()
	{
        biome = b;
    }
}