using extOSC;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//print the current time in a hour / minute / second format

public class TimeStamp : MonoBehaviour
{
    public string timeStamp; // The current time stamp

    void FixedUpdate()
    {
        // Get the current time with millisecond precision
        DateTime now = DateTime.Now; // Get the current date and time
        float timeInSeconds = Time.time; // Get the current time in seconds since the start of the game
        int milliseconds = now.Millisecond; // Get the current millisecond value of the time

        // Format the current time as a string
        timeStamp = string.Format("Current time: {0}:{1:00}:{2:00}.{3:000}", now.Hour, now.Minute, now.Second, milliseconds);
    }
}
