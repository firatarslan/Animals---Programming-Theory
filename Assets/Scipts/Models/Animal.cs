using UnityEngine;
using UnityEditor.Compilation;

public abstract class Animal : MonoBehaviour // MAIN CLASS
{
    // ENCAPSULATION Properties
    public int Live { get; set; }
    public string Details { get; set; }
 
    public virtual void Walk()// POLYMORPHISM
    {
        Debug.Log("im walking");
    }

    // ABSTRACTION
    public abstract void GiveDetails();

}
