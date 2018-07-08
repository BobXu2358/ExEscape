using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOff : MonoBehaviour {

    public GameObject man;
    public GameObject car;
    public GameObject carPark;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("col!");
        GameObject col = collision.gameObject;
        if(col.tag.Equals("Player"))
        {
            Debug.Log("inside!");
            col.GetComponent<Move>().moveSpeed = 2.0f;
            man.SetActive(true);
            car.SetActive(false);
            carPark.SetActive(true);
        }

    }
}
