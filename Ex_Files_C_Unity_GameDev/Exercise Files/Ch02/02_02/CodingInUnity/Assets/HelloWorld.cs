using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	public string text = "Hello World";
	public bool turnOn = true;
	public float posX = 5.0f;
	public int intTest = 5;

	string[] names = new string[]{"Jesse", "Freeman"};

	// Use this for initialization
	void Start () {

		//names [0] = "Jesse";


		//text = Test ("Calling Test()");//"Updated during Start()";

		print (names[0]+" "+names[1]);
		print ("Total Names "+names.Length);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	string Test(string value){
		return value + " Updated during Text()";
	}
}
