using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {
	Vector3 MousPo;
	GameObject player;
	public float Speed;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("player");
		MousPo = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		_Follow ();

	}

	void _Follow(){
		if(player==null)
			return;
		MousPo = player.transform.position;
		MousPo = new Vector3 (MousPo.x,MousPo.y,0);
		transform.position = Vector3.Lerp (transform.position, MousPo, Speed * Time.deltaTime);
		
	}
}
