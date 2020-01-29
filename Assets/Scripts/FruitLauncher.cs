using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitLauncher : MonoBehaviour
{
	public GameObject fruit;
	public float minInterval;
	public float maxInterval;
	public float startTime;
	
	
    // Start is called before the first frame update
    public void StartShooting()
    {
       InvokeRepeating("ShootFruit",startTime,Random.Range(minInterval,maxInterval));
    }

    // Update is called once per frame
    void ShootFruit()
    {
         Instantiate(fruit,this.transform.position, this.transform.rotation);
    }
}
