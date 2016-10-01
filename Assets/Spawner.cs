using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject SmallSphere;

	// Use this for initialization
	void Start () {
		var pos = transform.position;

		var spheres = new GameObject[3];

		var pos_adjust = 0;

		for (int i = 0; i < spheres.Length; i++) {
			spheres[i]  = Instantiate(SmallSphere, new Vector3(pos.x + i, pos.y + 2, pos.z), Quaternion.identity);
			spheres[i].SetActive(true);
		}
			

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
