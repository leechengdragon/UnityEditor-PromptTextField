using UnityEditor;

public class TestWindow : EditorWindow
{
    [MenuItem("Test/TestWindow")]
    public static void ShowWindow()
    {
        GetWindow<TestWindow>().Show();
    }
}
