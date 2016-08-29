using UnityEngine;

public class SpawnObstacles : MonoBehaviour {
    [SerializeField]
    private GameObject groundPrefab;

    [SerializeField]
    private GameObject tubesPrefab;

    [SerializeField]
    private float minTubesVerticalOffset = -1.0f;
    [SerializeField]
    private float maxTubesVerticalOffset = 3.0f;

    private float xSpawnPosition;
    private float spawnStepX;

	private void Start () {
        float screenWidth = Screen.width / Screen.dpi;
        spawnStepX = groundPrefab.GetComponent<BoxCollider2D>().size.x;

        for (xSpawnPosition = -screenWidth / 2.0f; xSpawnPosition < screenWidth / 2.0f + spawnStepX; xSpawnPosition += spawnStepX)
        {
            Instantiate(groundPrefab, new Vector3(xSpawnPosition, 0.0f, 0.0f), Quaternion.identity);
        }
    }

    public void SpawnNextObstacle()
    {
        Instantiate(groundPrefab, new Vector3(xSpawnPosition, 0.0f, 0.0f), Quaternion.identity);

        var tubesVerticalOffset = Random.Range(minTubesVerticalOffset, maxTubesVerticalOffset);
        Instantiate(tubesPrefab, new Vector3(xSpawnPosition, tubesVerticalOffset, 0.0f), Quaternion.identity);
        xSpawnPosition += spawnStepX;
    }
}
