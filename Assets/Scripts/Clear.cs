using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour {

    // Use this for initialization
    public bool destroyed;
    public bool moving;
    public GameObject waypoint ;


	void Start () {
        Debug.Log(waypoint.transform.position.x);
	}

	private void OnMouseDown()
	{
        moving = true;
	}

	// Update is called once per frame
	void Update()
    {
        if(destroyed){
            Destroy(gameObject);
            FixedMovement fm = GameObject.Find("Player").GetComponent<FixedMovement>() as FixedMovement;
            fm.speed = 1;

        }
        if(moving){
           move();

        }
    }
	private void move()
	{
        Vector2 target = new Vector2(waypoint.transform.position.x, waypoint.transform.position.y);
        float speed = 1.0f;
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target, Time.deltaTime * speed);
	
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            moving = false;
        }
    
    }
}
