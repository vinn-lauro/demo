using Demo.Sample;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        AbstractPrototype shallowPrototype = new ShallowCopyPrototype("Product A");
        AbstractPrototype shallowClone = shallowPrototype.Clone();
        shallowClone.Name = "Product A -- Refurbished";
        Console.WriteLine($"{shallowPrototype.Name} cloned to another {shallowClone.Name}");

        shallowPrototype.Reference.x = 5;
        shallowClone.Reference.x = 9;
        Console.WriteLine($"{shallowPrototype.Reference.x} compare to {shallowClone.Reference.x}");

        AbstractPrototype deepPrototype = new DeepCopyPrototype("Product B");
        AbstractPrototype deepClone = deepPrototype.Clone();

        deepPrototype.Reference.x = 2;
        deepClone.Reference.x = 11;
        Console.WriteLine($"{deepPrototype.Reference.x} compare to {deepClone.Reference.x}");

        BulletManager<LaserBullet> emitter = new BulletManager<LaserBullet>(9);
        emitter.Fire(5);
    }
}
