using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    private const string GameSceneName = "MainScene";

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.RemoveAllListeners();
        playButton.onClick.AddListener(() =>
        {
            LoadGameScene();
        });
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene(GameSceneName);
    }
}
