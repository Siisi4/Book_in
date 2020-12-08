using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item3found : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource foundsound;

    void Start()
    {
        item1 = PlayerPrefs.GetInt("item3", 0);

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
            foundsound.Play();
            item1 += 1;
            PlayerPrefs.SetInt("item3", 10);
            gameObject.SetActive(false);
        }
    }
}
