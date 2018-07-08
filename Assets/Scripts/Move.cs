using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    public GameObject[] waypoint;
    private int index = 0;
    public float moveSpeed = 2.0f;
    public GameObject playerCharacter;
    public string levelName;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 target = new Vector2(waypoint[index].transform.position.x, waypoint[index].transform.position.y);

        //move
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target, Time.deltaTime * moveSpeed);

        //reached a waypoint
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            //out of way points
            if (index == waypoint.Length - 1)
            {
                SceneManager.LoadScene(levelName);
            }
            //switch next waypoint
            gameObject.transform.Rotate(0, 180, 0);
            index++;
        }

    }

}
