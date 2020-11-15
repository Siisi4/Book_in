using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item1found : MonoBehaviour
{
    // Start is called before the first frame update


    void Start()
    {
        item1 = PlayerPrefs.GetInt("item", 0);

        if(item1 > 0)
        {
            gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int item1;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Player")
        {
            item1 += 1;
            PlayerPrefs.SetInt("item", 10);
            gameObject.SetActive(false);
        }
    }
}
