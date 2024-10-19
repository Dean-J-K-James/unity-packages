/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

/**
 * 
 */
public class BiomeData : EntityData
{
	public readonly Biome entity; //
    public readonly int x; //
    public readonly int y; //

    /**
	 * 
	 */
    public BiomeData(Biome b, int x, int y) : base()
	{
		entity = b;
        this.x = x;
        this.y = y;
    }
}