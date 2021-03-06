﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOnObject : MonoBehaviour
{

    // Colors and Renderer
    Color m_MouseOverRed = Color.red;
    Color m_OriginalColor;
    MeshRenderer m_Renderer;

    private void OnMouseOver()
    {
        //Debug.Log("Mouse on GameObject");
        
        m_Renderer.material.color = m_MouseOverRed;
        
        
    }

    private void OnMouseExit()
    {
        m_Renderer.material.color = m_OriginalColor;
    }

    // Start is called before the first frame update
    void Start()
    {   
        // Find Renderer materials
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
