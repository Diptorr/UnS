using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullettime : MonoBehaviour
{
    public float slowdownFactor = 0.5f;
    public void DoSlowmotion ()
    {
        Time.timeScale = slowdownFactor;
    }
}