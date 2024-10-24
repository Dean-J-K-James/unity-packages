/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

/**
 * 
 */
public class ChunkData : EntityData
{
    public readonly Biome biome; //
    public readonly Chunk chunk; //
    public readonly int x; //
    public readonly int y; //

    /**
	 * 
	 */
    public ChunkData(Chunk c, Biome b, int x, int y) : base()
    {
        biome = b;
        chunk = c;
        this.x = x;
        this.y = y;
    }
}