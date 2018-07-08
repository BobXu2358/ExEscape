using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour {

    public GameObject burger;
    private Animator anim;
    private bool interactive = false;
    public GameObject man;

	// Use this for initialization
	void Start () {
        anim = burger.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButtonDown(0))
        {
            if (interactive)
            {
                gameObject.SetActive(false);
                anim.SetBool("eat", true);
            }
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            anim.Play("burger_shake");
            interactive = true;
        }
    }
}
