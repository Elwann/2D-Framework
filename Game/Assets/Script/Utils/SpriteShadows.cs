using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SpriteShadows : MonoBehaviour {
	public bool castShadows = true;
	public bool receiveShadows = true;

	// Use this for initialization
	void Start () {
		renderer.castShadows = castShadows;
		renderer.receiveShadows = receiveShadows;
	}
}
