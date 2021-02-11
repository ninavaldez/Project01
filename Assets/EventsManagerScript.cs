using System;
// using System.Collections.Generic;
using UnityEngine;

public class EventsManagerScript : MonoBehaviour
{
    public void MessageConsole()
    {
        Debug.Log("Button Clicked TimeStamp: " + DateTime.Now);
    }
}
