using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StudentController : MonoBehaviour
{
    private Animal secilenHayvan;
    TextMeshProUGUI textMeshProUGUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SecileniOzetle();
        }
    }
    private void SecileniOzetle()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit; 
        if (Physics.Raycast(ray, out hit))
        {
            secilenHayvan = hit.collider.gameObject.GetComponent<Animal>();
            //call and debug
            secilenHayvan.Walk();
            secilenHayvan.GiveDetails();
        }
    }
}
