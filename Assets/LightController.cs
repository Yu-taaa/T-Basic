using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Time.time > 3.0f) {
			transform.rotation = Quaternion.Euler (Time.time * 30.0f, 0, 0);
		}

		if (Time.time > 20.0f) {
			transform.rotation = Quaternion.Euler (50.0f, -30.0f, 0);
		}
	}
}