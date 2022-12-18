using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera cam;
    public Scoring score;
    AudioSource  m_shootingSound;

void Start()
{
    m_shootingSound = GetComponent<AudioSource>();
}

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            m_shootingSound.Play();
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();

                if(target != null)
                {
                    
                    target.Hit();
                    score.AddScore(1);
                }
            }
        }
    }
    
}

