using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	public string text = "Hello World";
	public bool turnOn = true;
	public float posX = 5.0f;
	public int intTest = 5;

	// Use this for initialization
	void Start () {
		text = Test ("Calling Test()");//"Updated during Start()";

		print ("Hello World " + posX);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	string Test(string value){
		return value + " Updated during Text()";
	}
}
