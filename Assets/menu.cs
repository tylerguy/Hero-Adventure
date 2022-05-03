using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
  public Button StartButton;
  // Start is called before the first frame update
  void Start() { StartButton.onClick.AddListener(TaskOnClick); }

  void TaskOnClick() { SceneManager.LoadScene("Level1"); }

  // Update is called once per frame
  void Update() {}
}
