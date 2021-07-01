using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int wpIndex = 0;

    [SerializeField] float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[wpIndex].transform.position) < .1f)
        {
            wpIndex++;
            if (wpIndex >= waypoints.Length)
            {
                wpIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[wpIndex].transform.position, speed * Time.deltaTime);
    }
}
