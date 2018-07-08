using UnityEngine;
using System.Collections;

public class Collide : MonoBehaviour
{
    public GameObject house;
    private Animator anim;
    public bool interactive = false;

    void Start()
    {
        anim = house.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnCollisionEnter2D");
        GameObject col = other.gameObject;

        if (col.tag.Equals("Player"))
        {
            col.GetComponent<Move>().moveSpeed = 0.0f;
            anim.Play("house_shake");
            interactive = true;
        }
    }
}