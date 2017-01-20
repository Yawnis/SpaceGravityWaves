using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	List<PlanetScript> planetList = new List<PlanetScript>();


	// Use this for initialization
	void Start () {
		PlanetScript[] planets = FindObjectsOfType<PlanetScript> ();
		planetList.AddRange (planets);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public List<PlanetScript> GetAllPlanets(){
		return planetList;
	}
}
