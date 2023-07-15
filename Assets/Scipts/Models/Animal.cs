using UnityEngine;
using UnityEditor.Compilation;

public abstract class Animal // MAIN CLASS
{
    // ENCAPSULATION Properties
    public int Age { get; set; }
    public string Name { get; set; }
    public float Speed { get; set; }
 
    public virtual void Walk()// POLYMORPHISM
    {
        Debug.Log("im walking");
    }

    // ABSTRACTION
    public abstract void GiveVoice();

}
