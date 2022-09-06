using UnityEngine;
using Random = System.Random;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlatformPrefab;
    public int MinimumPlatforms;
    public int MaximumPlatforms;
    public float DistanceBetweenPlatforms;
    public Transform FinishPlatform;
    public Transform CylinderRoot;
    public float ExtraCylinderScale = 1f;
    public Game Game;

    private void Awake()
    {
        int levelIndex = Game.LevelIndex;
        Random random = new Random(levelIndex);
        int platformsCount = RandomRange(random, MinimumPlatforms, MaximumPlatforms + 1);

        for (int i = 0; i < platformsCount; i++)
        {
            int prefabIndex = RandomRange(random, 0, PlatformPrefabs.Length);

            GameObject platformPrefab = i == 0? FirstPlatformPrefab : PlatformPrefabs[prefabIndex];
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformPOsition(i);
            if(i > 0)
                platform.transform.localRotation = Quaternion.Euler(0, RandomRange(random, 0, 360f), 0);
        }

        FinishPlatform.localPosition = CalculatePlatformPOsition(platformsCount);

        CylinderRoot.localScale = new Vector3(1, platformsCount * DistanceBetweenPlatforms + ExtraCylinderScale, 1);
    }

    private int RandomRange(Random random, int min, int maxExlusive)
    {
        int number = random.Next();
        int lenght = maxExlusive - min;
        number %= lenght;
        return min + number;
    }

    private float RandomRange (Random random, float min, float max)
    {
        float t = (float)random.NextDouble();
        return Mathf.Lerp(min, max, t);
    }
    private Vector3 CalculatePlatformPOsition(int platformIndex)
    {
        return new Vector3(0, -DistanceBetweenPlatforms * platformIndex, 0);
    }
}
