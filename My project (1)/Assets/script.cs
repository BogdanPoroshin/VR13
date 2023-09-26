using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public float speed = 10f;
    public int b;
    public int c;
    public GameObject cam;
    public GameObject bcam;
    public Text x;
    public GameObject sphere;
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (c <= 0)
        {
            cam.SetActive(true);
            bcam.SetActive(false);
            this.gameObject.SetActive(false);
            x.text = "Игра окончена";

        }
        else
        {
            x.text = c.ToString();
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * speed * Time.deltaTime);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CET");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("CS");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TE");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TX");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TS");
    }
    
    public void heal()
    {
        c = 5;
    }
}
