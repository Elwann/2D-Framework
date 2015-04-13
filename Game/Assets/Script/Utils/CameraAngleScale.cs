using UnityEngine;
using System.Collections;

[AddComponentMenu("2D Framework/Utils/Camera Angle Scale")]
public class CameraAngleScale : MonoBehaviour {
	public bool scaleY = true;
	public bool scaleZ = true;

	// Use this for initialization
	void Start () {
		Vector3 scale = new Vector3(1f, 1f, 1f);

		if(scaleY){ scale.y = 1 / Mathf.Cos(Mathf.Deg2Rad * Camera.main.transform.eulerAngles.x); }
		if(scaleZ){ scale.z = 1 / Mathf.Sin(Mathf.Deg2Rad * Camera.main.transform.eulerAngles.x); }

		transform.localScale = scale;
	}
}
