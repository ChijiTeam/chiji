using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCamera : MonoBehaviour {
	public Transform followTarget;
	public Vector3 followPos;
//	public Vector3 followAngles;
	// Use this for initialization
	void Start () {
//		transform.eulerAngles = followAngles;
	}
	
	// Update is called once per frame
	void Update () {
		if (followTarget != null) {
			transform.position = followTarget.position + followPos;
//			transform.eulerAngles = followAngles;
			transform.LookAt(followTarget);
		}
	}
}
