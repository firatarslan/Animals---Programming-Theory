using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public override void GiveVoice()
    {
        Debug.Log("Miyavv");
    }
    public override void Walk()
    {
        Debug.Log("im Cat walking with this speed:  " + Speed);
    }
}
