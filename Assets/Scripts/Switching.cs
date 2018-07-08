using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switching : MonoBehaviour {

    public Transform next;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log(collision.gameObject.name);

        collision.gameObject.transform.position = next.position;
        Debug.Log("21111121221");
    }

}
