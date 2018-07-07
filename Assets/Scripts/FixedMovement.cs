using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedMovement : MonoBehaviour {

    public GameObject[] waypoints;
    private int i = 0;
    public float speed = 5.0f;

    // Use this for initialization
    void Start () {
        i = 0;
	}

    // Update is called once per frame
    void Update()
    {

        Vector2 target = new Vector2(waypoints[i].transform.position.x, waypoints[i].transform.position.y);

        //move
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target, Time.deltaTime * speed);

        //reached a waypoint
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            //switch next waypoint
            i++;
            transform.Rotate(0, 180, 0);
        }

    }
}
