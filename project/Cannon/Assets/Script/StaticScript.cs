using UnityEngine;
using System.Collections;

public class StaticScript : MonoBehaviour {

	Vector3 originalPos;
	// Use this for initialization
	void Start () {
		originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = originalPos;
	}
}
