using UnityEngine;
using System.Collections;

public class CameraAngleScale : MonoBehaviour {
	public bool scaleY = true;
	public bool scaleZ = true;

	// Use this for initialization
	void Start () {
		Vector3 scale = new Vector3(1f, 1f, 1f);

		if(scaleY){
			scale.y = 1 / Mathf.Sin(Camera.main.transform.rotation.x);
		}

		if(scaleZ){
			scale.z = 1 / Mathf.Cos(Camera.main.transform.rotation.x);
		}

		transform.localScale = scale;
	}
}
