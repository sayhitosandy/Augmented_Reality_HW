using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour {

    public GameObject bullet;
    public Transform spawnPos;
    GameObject troll;

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "troll" && troll == null)
        {
            troll = obj.gameObject;
            InvokeRepeating("Shoot", 0, 1.0f);
        }
    }

    void Shoot()
    {
        Instantiate(bullet, spawnPos.position, spawnPos.rotation);
        if (troll.GetComponent<Move>().dead)
        {
            troll = null;
            CancelInvoke("Shoot");
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject == troll)
        {
            troll = null;
            CancelInvoke("Shoot");
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (troll != null)
        {
            this.transform.LookAt(troll.transform.position);
        }
	}
}
