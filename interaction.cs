using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class interaction : MonoBehaviour
{
    public GameObject histoire;
    public GameObject text;
   

    public bool touch;


    // Start is called before the first frame update
    void Start()
    {
        touch = false;
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {

            Debug.Log(hit.transform.name);
            touch = true;
        }
        else
        {
            touch = false;
        }


        if (touch == true)
        {
            text.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                text.SetActive(false);
                histoire.SetActive(true);

                
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                text.SetActive(true);
                histoire.SetActive(false);


            }

        }
        else
        {
            text.SetActive(false);
        }







    }
}
