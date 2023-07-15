using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
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
