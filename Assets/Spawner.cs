using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject SmallSphere;

	// Use this for initialization
	void Start () {
		var pos = transform.position;
		var sphere = Instantiate(SmallSphere, new Vector3(pos.x, pos.y + 2, pos.z), Quaternion.identity);
		sphere.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
