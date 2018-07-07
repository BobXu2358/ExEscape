using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public SpriteRenderer playerSprite;
    public SpriteRenderer carSprite;
    bool interactive = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (interactive)
        {
            //left mouse click or screen touch
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
            }
        }
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactive = true;
        Debug.Log("here");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactive = false;
        Debug.Log("out!");
    }
}
