using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionGraphHide : MonoBehaviour
{
    public GameObject optgraphhide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        optgraphhide.SetActive(false);
    }
}
