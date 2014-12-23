using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    public float lifeTime = 0f;

	void Start () {
    Destroy(gameObject, lifeTime);
	}
}
