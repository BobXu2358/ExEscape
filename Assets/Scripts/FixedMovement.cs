using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FixedMovement : MonoBehaviour {

    public GameObject[] waypoints;
    private int i = 0;
    private int turn = 0;
    public float speed = 5.0f;
    public GameObject character;
    public GameObject car1;
    public GameObject car2;

    // Use this for initialization
    void Start ()
    {
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
            //out of way points
            if (i == waypoints.Length - 1)
            {
                SceneManager.LoadScene("level1");
            }

            //switch next waypoint
            i++;
            character.transform.Rotate(0, 180, 0);

            if (turn == 0)
            {
                car1.SetActive(false);
                car2.SetActive(true);
                turn = 1;
            }
            else
            {
                car1.SetActive(true);
                car2.SetActive(false);
                turn = 0;
            }
        }

    }
    
}
