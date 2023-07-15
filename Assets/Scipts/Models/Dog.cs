using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //INHERITANCE
{
    public override void GiveVoice()
    {
        Debug.Log("havv");
    }
    public override void Walk()
    {
        Debug.Log("im dog walking with this speed:  " + Speed);
    }
}
