using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseOnRed : MonoBehaviour
{
    public GameObject MenuDesMissions;
    private void OnMouseDown()
    {
        MenuDesMissions.SetActive(true);
    }

    void MenuDesMissionsOff()
    {
        MenuDesMissions.SetActive(false);
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
