using UnityEngine;
using UnityEditor.Compilation;

public abstract class Animal
{
    public int Age { get; set; }
    public string Name { get; set; }
    public float Speed { get; set; }

    public virtual void Walk()
    {
        Debug.Log("im walking");
    }

    public abstract void GiveVoice();

}
