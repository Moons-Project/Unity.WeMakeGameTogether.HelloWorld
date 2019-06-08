using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transport : MonoBehaviour {

  public GameObject fly;
  public string sceneName;

  void OnTriggerEnter2D(Collider2D col) {
    Debug.Log(col);
    if (col.gameObject.tag.Equals("Player")) {
      fly.SetActive(true);
      fly.GetComponent<Animator>().Play("fly_fly");
      col.gameObject.GetComponent<Animator>().Play("fly");
      StartCoroutine(PlayerAttack());
    }
  }

  IEnumerator PlayerAttack() {
    yield return new WaitForSeconds(1.0f);
    SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
  }
}