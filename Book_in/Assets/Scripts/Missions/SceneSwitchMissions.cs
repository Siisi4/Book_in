using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchMissions : MonoBehaviour
{
    public void LoadMissions(){
        SceneManager.LoadScene("Missions");
    }
    public void LoadItems(){
        SceneManager.LoadScene("ItemsScene");
    }
    public void LoadProust(){
        SceneManager.LoadScene("Proust");
    }
    public void LoadAcrostiche(){
        SceneManager.LoadScene("Acrostiche");
    }
    public void LoadFruits(){
        SceneManager.LoadScene("Fruits");
    }
    public void LoadTableau(){
        SceneManager.LoadScene("Tableau");
    }
    
    
}
