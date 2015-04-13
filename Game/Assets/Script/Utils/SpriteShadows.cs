using UnityEngine;
using System.Collections;

[AddComponentMenu("2D Framework/Utils/Sprite Shadows")]
[ExecuteInEditMode]
public class SpriteShadows : MonoBehaviour {
	public bool castShadows = true;
	public bool receiveShadows = true;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().castShadows = castShadows;
		GetComponent<Renderer>().receiveShadows = receiveShadows;
	}
}
