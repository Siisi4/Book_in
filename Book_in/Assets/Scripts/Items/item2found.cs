using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item2found : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource foundsound;

    void Start()
    {
        item1 = PlayerPrefs.GetInt("item2", 0);

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
            PlayerPrefs.SetInt("item2", 10);
            gameObject.SetActive(false);
        }
    }
}
