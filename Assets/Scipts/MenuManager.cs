using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] InputField studentName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NewGameStart()
    {
        if (studentName != null)
        {
            MainManager.Instance.studentName = studentName.text;
        }
        else
        {
            MainManager.Instance.studentName = "anonymous";
        }
        PlayerPrefs.SetString("studentName",studentName.text);
        SceneManager.LoadScene(1);
    }
}
