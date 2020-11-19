using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionsCanvasOpener : MonoBehaviour
{
    public GameObject ChatCanvas;
    public GameObject PapiCanvas;
    public GameObject RenneCanvas;
    public GameObject RenardCanvas;
    public GameObject OursCanvas;

    public void openchatcanvas(){
        ChatCanvas.SetActive(true);
        PapiCanvas.SetActive(false);
        RenneCanvas.SetActive(false);
        RenardCanvas.SetActive(false);
        OursCanvas.SetActive(false);
    }

    public void openpapicanvas(){
        PapiCanvas.SetActive(true);
        ChatCanvas.SetActive(false);
        RenneCanvas.SetActive(false);
        RenardCanvas.SetActive(false);
        OursCanvas.SetActive(false);
    }

    public void openrennecanvas(){
        RenneCanvas.SetActive(true);
        ChatCanvas.SetActive(false);
        PapiCanvas.SetActive(false);
        RenardCanvas.SetActive(false);
        OursCanvas.SetActive(false);
    }

    public void openrenardcanvas(){
        RenardCanvas.SetActive(true);
        ChatCanvas.SetActive(false);
        PapiCanvas.SetActive(false);
        RenneCanvas.SetActive(false);
        OursCanvas.SetActive(false);
    }

    public void openourscanvas(){
        OursCanvas.SetActive(true);
        ChatCanvas.SetActive(false);
        PapiCanvas.SetActive(false);
        RenneCanvas.SetActive(false);
        RenardCanvas.SetActive(false);
    }
}
