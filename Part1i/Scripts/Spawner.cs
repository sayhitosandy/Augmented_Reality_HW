using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject troll;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 0, 0.7f);
	}

    void Spawn()
    {
        Instantiate(troll, this.transform.position, this.transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
