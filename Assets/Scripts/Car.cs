using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public GameObject man;
    public GameObject car;
    public GameObject player;
    //public Camera cam;
    bool interactive = false;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactive)
        {
            //left mouse click or screen touch
            //hop on the car
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
                man.SetActive(false);
                car.SetActive(true);
                player.GetComponent<FixedMovement>().speed = 4;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactive = true;
            Debug.Log("here");
            anim.Play("carShaking");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactive = false;
        Debug.Log("out!");
        anim.Play("carIdling");
    }
}
