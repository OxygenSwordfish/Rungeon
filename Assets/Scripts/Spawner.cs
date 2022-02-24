using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] track; 
    
    //public float spMin = 1f;
    //public float spMax = 2f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
  
            //Spawn();
		}

   public void Spawn() {
        Instantiate(track[Random.Range(0, track.GetLength(0))], transform.position, Quaternion.identity);
        //Invoke("Spawn", Random.Range(spMin,spMax));
    }
}
