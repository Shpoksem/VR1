using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public float Speed = 10f;
    public int a;
    public int b;
    public int c = 5;
    public GameObject cylinder;
    public Text x;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.left / 2 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 20 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right / 2 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 20 * Speed * Time.deltaTime);
        }
        if (c <= 0)
        {
            this.gameObject.SetActive(false);
            x.text = "Game Over";
        }
        else x.text = c.ToString();
        { 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
    private void OnMouseDown (){
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnMouseEnter()
    {
        cylinder.GetComponent<Renderer>().material.color = Color.yellow;
    }
    private void OnMouseExit()
    {
       cylinder.GetComponent<Renderer>().material.color = Color.black;
    }
    public void Hide()
    {
        transform.localScale = Vector3.zero;
    }
}
