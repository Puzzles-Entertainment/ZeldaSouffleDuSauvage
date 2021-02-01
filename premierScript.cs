using UnityEngine;
using System.Collections;

public class Deplacement : MonoBehaviour {


public float Speed= 5f;

  //Use this for initialization
  void Start() {

  }

  // Update is called once per frame
  void Update () {

      if(Input.GetKey(keyCode.LeftArrow))
      {
          transform.translate(-Vector3.right*Time.deltatime*Speed);
      }
    
     if(Input.GetKey(keyCode.RightArrow))
      {
          transform.translate(Vector3.right*Time.deltatime*Speed);
      }
      if(Input.GetKey(keyCode.UpArrow))
      {
          transform.translate(Vector3.forward *Time.deltatime*Speed);
      }
       if(Input.GetKey(keyCode.DownArrow))
      {
          transform.translate(-Vector3.forward *Time.deltatime*Speed);
      }
}