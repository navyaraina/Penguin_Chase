using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using TMPro;

public class translation : MonoBehaviour
{

    Gyroscope m_Gyro;
    public float speed=35f;
    public Rigidbody rb;
    public GameObject Sphere;
    float dx,dz;
    public GameObject myPrefab;

    void Start(){
        // m_Gyro = Input.gyro;
        // m_Gyro.enabled = true;
    }
    void Update()
    {
        // float h=Input.GetAxis("Horizontal");
        // float v=Input.GetAxis("Vertical");
        // Vector3 tempVect = new Vector3(h, 0, v);
        // tempVect = tempVect.normalized * speed * Time.deltaTime;
        // rb.MovePosition(rb.transform.position + tempVect);
        // Sphere.transform.position+=m_Gyro.userAcceleration;
        
        // transform.position+= new Vector3(m_Gyro.userAcceleration.x * speed * Time.deltaTime,0,m_Gyro.userAcceleration.z * speed * Time.deltaTime);

        dx=Input.acceleration.x*speed;
        dz=-Input.acceleration.z*speed;
        transform.Rotate(Vector3.up*0* Time.deltaTime);
        Sphere.transform.position= new Vector3(Mathf.Clamp(transform.position.x,-17.9f,12.9f),transform.position.y,Mathf.Clamp(transform.position.z,-33.2f,1.3f));
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("collectables")){
            rb.isKinematic = false;
            other.gameObject.SetActive(false);
            // Instantiate(myPrefab, new Vector3(transform.position.x,transform.position.y,transform.position.z), Quaternion.identity);
        }
        else if(other.gameObject.CompareTag("mountains")){
            rb.isKinematic = true;
        }
        else{
            rb.isKinematic = false;
        }
    }
    private void FixedUpdate(){
        rb.velocity=new Vector3(dx,0,dz);
    }
}