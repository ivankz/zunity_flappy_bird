using UnityEngine;
using UnityEngine.UI;

public class TriggerDetector : MonoBehaviour {
    [SerializeField]
    private GameObject game;

    [SerializeField]
    private Score score;

    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.tag)
        {
            case "Grounds":
                game.GetComponent<SpawnObstacles>().SpawnNextObstacle();
                break;

            case "Tubes":
                score.score = score.score + 1;
                break;
        }
    }
}
