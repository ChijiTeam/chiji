using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTop : MonoBehaviour {

	public MeshRenderer mesh;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collider)  
	{  
		print("Enter ::: "+this.name);  
//		this.gameObject.SetActive (false);
		mesh.enabled = false;


	}  
	void OnTriggerExit(Collider collider)  
	{  
		print("out ::: "+this.name);  
//		this.gameObject.SetActive (true);

		mesh.enabled = true;
	} 
}
