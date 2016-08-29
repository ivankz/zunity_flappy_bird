using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AddForceOnClick : MonoBehaviour {
    [SerializeField]
    private Vector2 force = Vector2.up;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
        }
    }
}
