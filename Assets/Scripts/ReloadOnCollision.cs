using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnCollision : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
