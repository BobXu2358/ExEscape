using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {

    public GameObject bridge;
    public GameObject bridgeSet;
    public GameObject player;
    private Animator anim;
    private Move mv;
    private bool interactive = false;

	// Use this for initialization
	void Start () {
        anim = bridge.GetComponent<Animator>();
        mv = player.GetComponent<Move>();
	}
	
	// Update is called once per frame
	void Update () {
		if(interactive)
        {
            if(Input.GetMouseButtonDown(0))
            {
                mv.moveSpeed = 2.0f;
                anim.Play("bridge_idle");
                bridge.SetActive(false);
                bridgeSet.SetActive(true);
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject col = collision.gameObject;
        if(col.tag.Equals("Player"))
        {
            anim.Play("bridge_shake");
            mv.moveSpeed = 0.0f;
            interactive = true;
        }
    }

}
