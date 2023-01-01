using overrideTest;
internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new Dog("狗");
        Fish fish = new Fish("魚");
        string dogMakeNoise = dog.MakeSound("汪~");
        Console.WriteLine(dogMakeNoise);
        //魚不會叫，但必需使用Animal class其他屬性時
        string fishMakeNoise = fish.MakeSound("");
        Console.Write(fishMakeNoise);

    }
}