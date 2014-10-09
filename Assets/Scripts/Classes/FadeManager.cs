using UnityEngine;
using System.Collections;

public class FadeManager : SingletonMonoBehaviour<FadeManager>{
	// 暗転用黒テクスチャ
	private Texture2D blackTexture;
	// フェード中の透明度
	private float fadeAlpha = 0;
	// フェード中フラグ
	private bool isFadeing = false;

	// インスタンス生成時
	public void Awake () {
		// 黒テクスチャの生成
		this.blackTexture = new Texture2D(32, 32, TextureFormat.RGB24, false);
		this.blackTexture.ReadPixels(new Rect(0, 0, 32, 32), 0, 0, false);
		this.blackTexture.SetPixel(0, 0, Color.white);
		this.blackTexture.Apply();
	}

	public void OnGUI() {
		// フェード中なら処理終了
		if(!this.isFadeing) return; 

		// 透明度を更新して黒テクスチャを描画
		GUI.color = new Color(0, 0, 0, this.fadeAlpha);
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), this.blackTexture);
	}

	public void LoadLevel(string scene, float interval) {
		StartCoroutine(TransScene(scene, interval));
	}

	private IEnumerator TransScene(string scene, float interval) {
		// フェード中フラグ立てる
		this.isFadeing = true;

		// だんだん暗く
		float time = 0;

		while(time <= interval) {
			this.fadeAlpha = Mathf.Lerp(0f, 1f, time / interval);
			time += Time.deltaTime;
			yield return 0;
		}

		// シーン切り替え
		Application.LoadLevel(scene);

		// だんだん明るく
		time = 0;

		while(time <= interval) {
			this.fadeAlpha = Mathf.Lerp (1f, 0f, time / interval);
			time += Time.deltaTime;
			yield return 0;
		}

		// フェード完了時にフラグ折る
		this.isFadeing = false;
	}
}
