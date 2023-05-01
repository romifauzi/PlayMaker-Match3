using UnityEngine;
using System.Collections;

public class MaterialName : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (GetComponent<Renderer>().material.name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
