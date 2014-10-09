using UnityEngine;

public class SceneController : SingletonMonoBehaviour<SceneController> {
	// プロパティ
	public float   fadeSpeed = 0.5f;
	private bool   PushBtn   = false;
	private string SceneName = "";

	// ビルド時点でコールされる
	void Awake() {

	}

	// ボタンクリック(タッチ)時にコール
	public void UIBtnListener(GameObject gameObject){
		if(SceneName == "") {
			SceneName = gameObject.name.Substring(3);
			//FadeManager.Instance.LoadLevel(SceneName, fadeSpeed);
			Application.LoadLevel(SceneName);
			SceneName = "";
		}else {
			Debug.Log(SceneName);
		}
	}
}
