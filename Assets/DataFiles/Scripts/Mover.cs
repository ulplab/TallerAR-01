using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public float velocidad = 0.1f;
    Vector3 tamanio;
    Vector3 pos;
    Vector3 rot;
    float altura = 0;
    float incremento = 0.1f;
    // Use this for initialization
    void Start () {

        tamanio = new Vector3(transform.localScale.x, 0f, transform.localScale.z);
        pos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        rot = new Vector3(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z);
    }
	
	// Update is called once per frame
	void Update () {

        if (tamanio.y <= 5f)
        {
            //incremento += Time.deltaTime;
            tamanio.y  += incremento;
            pos.y += incremento / 2;
            transform.localPosition = pos;
            transform.localScale = tamanio;
            //transform.localRotation = Quaternion.LookRotation(rot);
            
        }
    }
}
