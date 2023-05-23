using UnityEngine;
using UnityEditor;


public static class MenuItems
{
	/// <summary>
	/// EnemyPrefab‘SXV
	/// </summary>
	[MenuItem("Custom/Dirty Materials")]
	public static void UpdateEnemies()
	{
		var materialGUID = AssetDatabase.FindAssets("t:Material");
		foreach (var guid in materialGUID)
		{
			var path = AssetDatabase.GUIDToAssetPath(guid);
			var mat = AssetDatabase.LoadAssetAtPath<Material>(path);
			EditorUtility.SetDirty(mat);
		}
	}
}
