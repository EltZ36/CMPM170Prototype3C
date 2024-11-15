using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource targetSound;
    void Start()
    {
        targetSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "boat")
        {
            GameManager.Instance.NumObjects--;
            targetSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "boat")
        {
            GameManager.Instance.NumObjects++;
        }
    }
}
