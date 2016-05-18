using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public void OnClick()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
