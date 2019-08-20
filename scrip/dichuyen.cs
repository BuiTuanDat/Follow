using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour {
	Vector3 MousPo;
	public float Speed;
	public Transform player;
	private bool touch=false;
	private Vector2 PointA;
	private Vector2 PointB;

    public GameObject joy1;
    public GameObject joy2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			PointA = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.transform.position.z));
            joy1.transform.position = PointA * 1;
            joy2.transform.position = PointA * 1;
            joy1.GetComponent<SpriteRenderer>().enabled = true;
            joy2.GetComponent<SpriteRenderer>().enabled = true;
        }
		if (Input.GetMouseButton (0)) {
			touch = true;
			PointB = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
		
		} else {
			touch = false;
		}
				
	}
	private void FixedUpdate(){
		if (touch) {
			Vector2 offset = PointB - PointA;
			Vector2 direction = Vector2.ClampMagnitude (offset, 1f);
			_Move (direction * 1);

            joy1.transform.position = new Vector2(PointA.x + direction.x, PointA.y + direction.y) * 1;
        }
        else
        {
            joy1.GetComponent<SpriteRenderer>().enabled = false;
            joy2.GetComponent<SpriteRenderer>().enabled = false;
        }
	}
	void _Move(Vector2 direction){
		player.Translate (direction * Speed * Time.deltaTime);
	}
}
