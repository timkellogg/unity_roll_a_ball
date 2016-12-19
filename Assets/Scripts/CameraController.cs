using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// called upon initialization
	void Start()
	{
		offset = transform.position - player.transform.position;
	}

	// called once per frame but it is gaurenteed to run after everything else
	void LateUpdate()
	{
		transform.position = player.transform.position + offset;
	}
}
