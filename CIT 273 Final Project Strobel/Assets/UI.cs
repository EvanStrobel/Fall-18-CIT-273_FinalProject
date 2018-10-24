using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Text partyText1;
    public Text partyText2;
    public Text partyText3;
    public GameObject member1;
    public GameObject member2;
    public GameObject member3;
    private Character character1;
    private Character character2;
    private Character character3;

    // Use this for initialization
    void Start () {
        character1 = member1.GetComponent<Character>();
        character2 = member2.GetComponent<Character>();
        character3 = member3.GetComponent<Character>();
        partyText1.text = character1.totalHealth.ToString();
        partyText2.text = character2.totalHealth.ToString();
        partyText3.text = character3.totalHealth.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
