using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Rigidbody projectile;                   
    public Transform m_FireTransform;           
    public AudioSource m_ShootingAudio;         
    public AudioClip m_ChargingClip;            
    public AudioClip m_FireClip;           
    private bool m_Fired;
    private float timestamp = 0;
    private Rigidbody oldProjectile;
    private bool shot = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oldProjectile is null || timestamp>7 )
        {
            Rigidbody shellInstance =
                Instantiate(projectile, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

            // Set the shell's velocity to the launch force in the fire position's forward direction.
            shellInstance.velocity = 25 * m_FireTransform.forward;
            ;

            // Change the clip to the firing clip and play it.
            oldProjectile = shellInstance;
            shot = false;
            m_ShootingAudio.clip = m_FireClip;
            m_ShootingAudio.Play();
            timestamp = 0;
        }
        
        if (!shot)
        {
            m_ShootingAudio.clip = m_FireClip;
            m_ShootingAudio.Play();
            shot = true;
        }
        timestamp += Time.deltaTime;
        
    }
}
