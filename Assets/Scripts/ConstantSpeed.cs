using UnityEngine;
using System.Collections;

public class ConstantSpeed : MonoBehaviour {
    [SerializeField]
    private Vector2 speed = Vector2.right;
	
	void Update () {
        transform.Translate(speed * Time.deltaTime);
	}
}

