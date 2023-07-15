using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //INHERITANCE
{
    public override void GiveDetails()
    {
        Debug.Log("Roof");
    }
    public override void Walk()
    {
        Debug.Log("im dog, walking slowly");
    }
}
