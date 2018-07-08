using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour {

    public GameObject waitingArea;
    private Collide col;
    public GameObject player;
    private Move mv;

	// Use this for initialization
	void Start () {
        col = waitingArea.GetComponent<Collide>();
        mv = player.GetComponent<Move>();
	}
	
	// Update is called once per frame
	void Update () {
		if(col.interactive)
        {
            if(Input.GetMouseButtonDown(0))
            {
                gameObject.transform.localScale = new Vector3(3, 3, 0);
                gameObject.GetComponent<Animator>().Play("house_idle");
                mv.moveSpeed = 2.0f;

            }
        }
	}
}
