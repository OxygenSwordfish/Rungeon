using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) //Checks for overlap with other objects
    {
        if (other.gameObject.transform.parent)          //Find object for prefabs
            Destroy(other.gameObject.transform.parent.gameObject); //Destroy parent game object
    }
}
