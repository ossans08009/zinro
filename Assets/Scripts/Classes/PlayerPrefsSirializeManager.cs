using UnityEngine;
using System.Collections;

public class PlayerPrefsSirializeManager : SingletonMonoBehaviour<PlayerPrefsSirializeManager> {
/*
	// <!!>
	public static void Save<T> (string prefKey, T serializableObject) {
		// メモリ使うクラス？
		MemoryStream memoryStream = new MemoryStream ();
		// バイナリ変換クラス？
		BinaryFormatter bf = new BinaryFormatter ();
		// メモリ上のバイナリデータに変換してる？
		bf.Serialize (memoryStream, serializableObject);
		// メモリ上のバイナリデータを文字列に変換してる？
		string tmp = System.Convert.ToBase64String (memoryStream.ToArray ());

		// 保存する
		PlayerPrefs.SetString ( prefKey, tmp );
	}
	
	public static T Load<T> (string prefKey) {
		if (!PlayerPrefs.HasKey(prefKey)) return default(T);
		BinaryFormatter bf = new BinaryFormatter();
		string serializedData = PlayerPrefs.GetString(prefKey);
		MemoryStream dataStream = new MemoryStream(System.Convert.FromBase64String(serializedData));
		T deserializedObject = (T)bf.Deserialize(dataStream);
		return deserializedObject;
	}
*/
}
