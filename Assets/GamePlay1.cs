using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GamePlay1 : MonoBehaviour
{
    public TMP_Text Text1;
    private int counter;
    void Start()
    {
        counter = 0;
    }
    void Update()
    {
        Text1.text = "Score:" + counter;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Sphere"))
                {
                    counter = counter + 1;
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }
}