using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChar : MonoBehaviour
{

public enum ch{ch1,ch2,ch3}
public ch a;
    
public GameObject model1, model2, model3;

    // Start is called before the first frame update
    void Start()
    {
        model1.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch(a)
        {
            case ch.ch1:
                model1.SetActive(true);
                model2.SetActive(false);
                model3.SetActive(false);
                break;
            case ch.ch2:
                model1.SetActive(false);
                model2.SetActive(true);
                model3.SetActive(false);
                break;
            case ch.ch3:
                model1.SetActive(false);
                model2.SetActive(false);
                model3.SetActive(true);
                break;
        }
    }
}
