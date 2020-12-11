using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenTableax : MonoBehaviour
{
    
    public GameObject TableauA;
    public GameObject TableauB;
    public GameObject BoutonMasquer;
    public GameObject BoutonMasquerB;

    
    // Tableau A
    public void OpenTableauA(){
        TableauA.SetActive(true);
        TableauB.SetActive(false);
        BoutonMasquer.SetActive(true);
        BoutonMasquerB.SetActive(false);
    }
    public void CloseTableauA(){
        TableauA.SetActive(false);
        BoutonMasquer.SetActive(false);
    }
   // Tableau B 
   public void OpenTableauB(){
       TableauB.SetActive(true);
       TableauA.SetActive(false);
       BoutonMasquer.SetActive(false);
       BoutonMasquerB.SetActive(true);
   }

   public void CloseTableauB(){
       TableauB.SetActive(false);
       BoutonMasquerB.SetActive(false);
   }
}
