using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenTableax : MonoBehaviour
{
    
    public GameObject TableauA;
    public GameObject TableauB;
    public GameObject TableauC;
    public GameObject BoutonMasquer;
    public GameObject BoutonMasquerB;
    public GameObject BoutonMasquerC;

    
    // Tableau A
    public void OpenTableauA(){
        TableauA.SetActive(true);
        TableauB.SetActive(false);
        TableauC.SetActive(false);
        BoutonMasquer.SetActive(true);
        BoutonMasquerB.SetActive(false);
        BoutonMasquerC.SetActive(false);
    }
    public void CloseTableauA(){
        TableauA.SetActive(false);
        BoutonMasquer.SetActive(false);
    }
   // Tableau B 
   public void OpenTableauB(){
       TableauB.SetActive(true);
       TableauA.SetActive(false);
       TableauC.SetActive(false);
       BoutonMasquer.SetActive(false);
       BoutonMasquerC.SetActive(false);
       BoutonMasquerB.SetActive(true);
   }

   public void CloseTableauB(){
       TableauB.SetActive(false);
       BoutonMasquerB.SetActive(false);
   }

   public void OpenTableauC(){
       TableauC.SetActive(true);
       TableauB.SetActive(false);
       TableauA.SetActive(false);
       BoutonMasquer.SetActive(false);
       BoutonMasquerB.SetActive(false);
       BoutonMasquerC.SetActive(true);
   }
   public void CloseTableauC(){
       TableauC.SetActive(false);
       BoutonMasquerC.SetActive(false);
   }
}
