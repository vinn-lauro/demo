namespace Demo.Sample;

public interface IBullet { IBullet Clone(); }

class ExplodingBullet : IBullet
{
    public IBullet Clone()
    {
        return (ExplodingBullet)this.MemberwiseClone();
    }
}

class LaserBullet : IBullet
{
    public IBullet Clone()
    {
        return (LaserBullet)this.MemberwiseClone();
    }
}

class BulletManager<T> where T : IBullet, new()
{
    public IBullet[] Cache;

    public BulletManager(int initialStock)
    {
        Cache = new IBullet[initialStock];
        for (int i = 0; i < initialStock; i++)
            Cache[i] = new T();
    }

    public void Fire(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Array.Resize(ref Cache, Cache.Length - 1);
            Console.WriteLine($"{Cache[0].GetType().Name} Fired. Current Stock: {Cache.Length}");

            if (Cache.Length < 7)
            {
                Array.Resize(ref Cache, Cache.Length + 1);
                Cache[Cache.Length - 1] = Cache[Cache.Length - 2].Clone();
                Console.WriteLine($"{Cache[Cache.Length - 1].GetType().Name} Added. Current Stock: {Cache.Length}");
            }
        }
    }
}