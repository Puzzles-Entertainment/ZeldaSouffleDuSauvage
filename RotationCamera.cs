using UnityEngine;
using System.Collections;

public class Deplacement : MonoBehaviour {



public float sensibiliteX = 15;
public float sensibiliteY = 15;
public float minX=-150;
public float maxX=150;
public float minY=-150;
public float maxY=150;


public float rotationX= 0;
public float rotationY= 0;

Quaternion originalRotationPlayer;
Quaternion originalRotationCamera;

public Camera Camera;
CharacterController controller;
public float Speed= 5f;

Vector3 VecMov = Vector3.zero

  //Use this for initialization
  void Start() {
      controller = gameObject.GetComponent<CharacterController>();
      originalRotationPlayer = transform.localRotation;
      originalRotationCamera = camera.transform.localRotation;

  }

  // Update is called once per frame
  void Update () {
    //Rotation de la camera
      rotationX= Input.GetAxis("MouseX")*sensibiliteX;
      rotationY= Input.GetAxis("MouseX")*sensibiliteY;
      rotationX= Mathf.Clamp(rotationX, minX,maxX);
      rotationY= Mathf.Clamp(rotationY, minY,maxY);
      Quaternion xQuaternion = Quaternion.AngleAxis (rotationX,Vector3.up);
      transform.localRotation = originalRotationPlayer * xQuaternion;
      camera.transform.localRotation = originalRotationPlayer * xQuaternion;
      
      
      
      
      
      
      
      
      
      
      
      
      
      /*if(Input.GetKey(keyCode.LeftArrow))
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
      }*/
}