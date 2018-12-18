using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changescript : MonoBehaviour {
    
    //variable, Text ist das Object
    
    public Text overrideText;

	// Use this for initialization
	void Start () {
        //zuweisung (aufgrund "=")
		overrideText.text = "Menschen umgeben sich mit anderen Menschen. Das ist im Alltag nicht zu vermeiden und es gibt einen natürlichen Trieb, sich ein soziales Netzwerk aufzubauen und sich in Gruppen zu integrieren. Aber was passiert, wenn plötzlich Ängste im Beisein anderer Menschen entstehen? Die sogenannte Soziale Phobie ist eine anerkannte Krankheit. Sie macht sich durch dauerhafte Angstzustände bemerkbar, die an die Anwesenheit anderer gebunden ist. 2 bis 8 Prozent der deutschen Bevölkerung leidet an der sozialen Angststörung – eine Zahl, die sich nicht exakt bestimmen lässt, da sich die Krankheit schwer von „natürlichen“ Eigenschaften wie Schüchternheit oder Introvertiertheit abgrenzen lässt.";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
