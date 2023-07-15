using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //INHERITANCE
{
    public override void GiveDetails()
    {
        Debug.Log("Meav");
    }
    public override void Walk()
    {
        Debug.Log("im Cat: runing");
    }
    
}
