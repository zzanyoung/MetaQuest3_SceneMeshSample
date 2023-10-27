using UnityEngine;
using System.IO;

public class SaveLoadManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameObjectsToSave;

    private string dataPath;

    private void Start()
    {
        dataPath = Path.Combine(Application.persistentDataPath, "saveData.json");
        if (dataPath != null)
      LoadPositionsAndRotations();

        InvokeRepeating(nameof(SavePositionsAndRotations), 0f, 1f);
    }

    public void SavePositionsAndRotations()
    {
        SaveData saveData = new SaveData();
        saveData.gameObjectsData = new GameObjectData[gameObjectsToSave.Length];

        for (int i = 0; i < gameObjectsToSave.Length; i++)
        {
            saveData.gameObjectsData[i] = new GameObjectData
            {
                position = gameObjectsToSave[i].transform.position,
                rotation = gameObjectsToSave[i].transform.rotation
            };
        }

        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(dataPath, json);
    }

    public void LoadPositionsAndRotations()
    {
        if (File.Exists(dataPath))
        {
            string json = File.ReadAllText(dataPath);
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);

            for (int i = 0; i < Mathf.Min(gameObjectsToSave.Length, saveData.gameObjectsData.Length); i++)
            {
                gameObjectsToSave[i].transform.position = new Vector3(saveData.gameObjectsData[i].position.x, saveData.gameObjectsData[i].position.y +1f, saveData.gameObjectsData[i].position.z);
                gameObjectsToSave[i].transform.rotation = saveData.gameObjectsData[i].rotation;
            }
        }
        else
        {
            Debug.LogError("Save file not found");
        }
    }

    [System.Serializable]
    private class SaveData
    {
        public GameObjectData[] gameObjectsData;
    }

    [System.Serializable]
    private class GameObjectData
    {
        public Vector3 position;
        public Quaternion rotation;
    }
}
