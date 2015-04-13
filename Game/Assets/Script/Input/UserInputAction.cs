using UnityEngine;
using System.Collections;

[AddComponentMenu("2D Framework/Input/Action")]
public class UserInputAction : MonoBehaviour {

	private Vector2 axis = new Vector2();
	private bool jump = false;
	public Vector2 Axis{ get{ return axis; } }
	
	void Start () {
		
	}
	
	void Update () {
		axis.x = Input.GetAxis("Horizontal");
		axis.y = Input.GetAxis("Vertical");
	}
}

public struct Btn{
	public bool up;
	public bool down;
	public bool held;
}