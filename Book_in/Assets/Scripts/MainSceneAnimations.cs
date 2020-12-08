using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneAnimations : MonoBehaviour
{
    Animation animLight;
    // Start is called before the first frame update
    void Start()
    {
        animLight = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        animLight.Play();
    }
}
