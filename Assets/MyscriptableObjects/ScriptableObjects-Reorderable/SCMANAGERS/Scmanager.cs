using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scmanager : MonoBehaviour
{
    public Text str;
    public EOData m_eoData;
    // Start is called before the first frame update
    void Start()
    {

        str.text = m_eoData.m_elementlist[0].name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
