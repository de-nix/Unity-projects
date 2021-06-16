using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    public AudioSource m_audio;

    public AudioClip m_clip;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
       // if (other.gameObject.tag == "CylinderRing")
      //  {
            m_audio.clip = m_clip;
            m_audio.Play();
      //  }
    }
}
