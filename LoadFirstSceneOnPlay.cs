using UnityEngine;
using UnityEngine.SceneManagement;

namespace fablesalive
{
    /*
    This script ensures that whenever the Play button is pressed in the Unity Editor, 
    the first scene (index 0) in the build settings is automatically loaded, regardless of which scene was active in the editor.
    
    No need to assign this script to any object; it just needs to be present in the project.
	*/
    
    public class LoadFirstSceneOnPlay : MonoBehaviour
    {

#if UNITY_EDITOR
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void LoadFirstScene()
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                SceneManager.LoadScene(0);
            }
        }
#endif
    }
}
