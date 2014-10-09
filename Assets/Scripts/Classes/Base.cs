using UnityEngine;

public class Base : SingletonMonoBehaviour<Base> {
	public int flag = 0;

	// いうなればコンストラクタ的な？
	void Awake() {
		if(this != Instance) {
			Destroy(this.gameObject);
			return;
		}else {
			flag = 1;
		}

		DontDestroyOnLoad(this.gameObject);
	}
}
