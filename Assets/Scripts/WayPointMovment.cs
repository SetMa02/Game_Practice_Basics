using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMovment : MonoBehaviour
{
    [SerializeField] private Transform path;
    [SerializeField] private float speed;
    private Transform[] points;
    private int currentPiont;

    void Start()
    {
        points = new Transform[path.childCount];

        for(int i = 0;i < path.childCount;i++)
        {
            points[i] = path.GetChild(i);
        }
    }

    void Update()
    {
        Transform target = points[currentPiont];
   
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if(transform.position == target.position)
        {
            currentPiont++;
            if (currentPiont >= points.Length)
            {
                currentPiont = 0;
            }
        }
    }
}
