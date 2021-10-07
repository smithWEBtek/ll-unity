using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

    public string text =  "Hello World";
    public bool turnOn = true;
    public float posX = 5.0f;
    public int intTest =  5;
    string[] names = new string[]{"Jesse", "Freeman"}; 
    List<string> animals = new List<string>(){"dog", "cat", "42"};
    Dictionary<string,string> weapons = new Dictionary<string,string>();


    // Start is called before the first frame update
    void Start () {

        animals.Add("fish");
        animals.Add("bird");

        animals.Remove("bird");

        // print("List to Array length "+animals.ToArray().Length);

        // names[0] = "Jesse";


        // text  = Test("Calling Test() w/arg"); //"Updated during start()";

        // print(names[0] + ' ' + names[1]);
        // print("Total Names "+names.Length);
        // print("Total Animals: "+animals.Count);
        // print("Animal 1: " + animals[0]);
        // print("Animal 3: " + animals[2]);
        // print("Last Animal: " + animals[animals.Count - 1]);


        // weapons.Add("slot1", "sword");

        // print("Weapon in slot1 " + weapons ["slot1"]);

        // print("Slot 2 equipped " + weapons.ContainsKey("slot2"));

        ConditionTest();
    }

    // Update is called once per frame
    void Update () {
        
    }

    string Test (string arg) {
        return arg + " *** " + " Updated with return during Test()";
    }

    void ConditionTest(){
        string name = "Freeman";
        if(name == "Jesse"){
            print("Name is Jesse");
        } else if(name == "Freeman"){
            print("Name IS Freeman");
        } else {
            print("Name is NOT Jesse");

        }

        int health = 3;
        bool isDead = health <= 0;

        // if(isDead){
        //     print ("Player is dead: " + isDead);
        // } else {
        //     print ("Player is dead? " + isDead);
        // }
        if(isDead)
            print ("Player is dead: " + isDead);
        
        if(!isDead)
            print ("Player is ALIVE!");
    }
}
