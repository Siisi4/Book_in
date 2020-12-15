using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowItem : MonoBehaviour
{
    public GameObject item1image;
    public GameObject item2image;
    public GameObject item3image;
    public GameObject item4image;

    public static int item1;
    public static int item2;
    public static int item3;
    public static int item4;
    
    void Start()
    {
        // monter item1 si > 0 :
        item1 = PlayerPrefs.GetInt("item", 0);

        if(item1 > 0)
        {
            item1image.SetActive(true);
        }
        else{
            item1image.SetActive(false);
        }

        // montrer item 2
        item2 = PlayerPrefs.GetInt("item2", 0);

        if(item2 > 0)
        {
            item2image.SetActive(true);
        }
        else{
            item2image.SetActive(false);
        }

        // item 3
        item3 = PlayerPrefs.GetInt("item3", 0);

        if(item3 > 0)
        {
            item3image.SetActive(true);
        }
        else{
            item3image.SetActive(false);
        }
        // item 4
        item4 = PlayerPrefs.GetInt("item4", 0);

        if(item4 > 0)
        {
            item4image.SetActive(true);
        }
        else{
            item4image.SetActive(false);
        }

    }

}
