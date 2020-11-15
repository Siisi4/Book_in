using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimatedSkies : MonoBehaviour
{
    public GameObject CanvasDesMissions;
    float scrollSpeed = 0.001f;
    Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));


        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Missions");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("ItemsScene");
        }
    }
}
