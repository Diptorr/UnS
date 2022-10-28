using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRewind : MonoBehaviour
{
    private bool isRewinding = false;

    List<Vector3> positions;

    void Start()
    {
        positions = new List<Vector3>();
    }
 void Update()    
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            StartRewind();
        if (Input.GetKeyUp(KeyCode.Tab))
            StopRewind();
    }
    void FixedUpdate()
    {
        if (isRewinding)
            Rewind();

        else Record();
    }

 void Rewind()
    {
        if (positions.Count > 0)
        {
            transform.position = positions[0];
            positions.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }
    void Record()
    {
        positions.Insert(0, transform.position);
    }

    public void StartRewind ()
    {
        isRewinding = true;
    }

    public void StopRewind ()
    {
        isRewinding = false;
    }

}
