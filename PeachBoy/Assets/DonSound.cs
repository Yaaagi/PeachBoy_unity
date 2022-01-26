using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundDon()
    {
        GetComponent<AudioSource>().Play();
    }
}
