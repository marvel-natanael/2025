using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    bool right = true, left = false;
    public float length;
    public float start;

    void Update()
    {
        float pos = GetComponent<Transform>().position.x;
        float posLimit = start - length;
        float posLimit2 = start + length;
        if (pos <= posLimit)
        {
            right = true;
            left = false;
        }

        if (posLimit2 <= pos)
        {
            left = true;
            right = false;
        }

        if (right)
        {
            Debug.Log(posLimit2);
            transform.position = Vector3.MoveTowards(transform.position, new Vector2(posLimit2, transform.position.y), 0.05f);
        }


        if (left)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector2(posLimit, transform.position.y), 0.05f);
        }
   }

}
