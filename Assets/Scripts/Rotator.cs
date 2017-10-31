using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed;
	private float dir;

	void Start()
	{
		dir = Random.Range (-1.0f, 1.0f);
	}

	// Update is called once per frame
	void Update () {
	
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime * dir * speed); // rotate each frame

	}
}
