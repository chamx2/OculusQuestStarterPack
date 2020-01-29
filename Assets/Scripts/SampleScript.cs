using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
	public float minForce;
	public float maxForce;
	public Rigidbody rb;
	public GameObject fruitSlice;
	
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
	   rb.AddForce(transform.forward * Random.Range(minForce,maxForce));
    }
	
	
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "wall") {
			
			Instantiate(fruitSlice,this.transform.position,this.transform.rotation);
			Destroy(this.gameObject);
		}
		
	}
	


    void Update () {
		
		Destroy(this.gameObject,5f);
		
	}
}
