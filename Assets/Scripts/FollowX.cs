using UnityEngine;
using System.Collections;

public class FollowX : MonoBehaviour {
    [SerializeField]
    private Transform followX;

    private float offsetX;

    void Start()
    {
        offsetX = transform.position.x - followX.position.x;
    }

    void LateUpdate()
    {
        var position = transform.position;
        position.x = followX.position.x + offsetX;
        transform.position = position;
    }
}
