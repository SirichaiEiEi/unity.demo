using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    int counter=0;

    void OnGUI()
    {
         GUI.Label (new Rect (100, 100, 200, 50), "COUNTER: " + counter); {
                 }
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name.CompareTo("RedSphere") == 0)
                if (Input.GetMouseButtonDown(0))
                counter++;
                {
                    hit.collider.gameObject.SetActive(false);
                }
                if (hit.collider.gameObject.name.CompareTo("BlueSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                }
                if (hit.collider.gameObject.name.CompareTo("GreenSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }
}
