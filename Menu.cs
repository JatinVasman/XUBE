using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   public void StartGame(){
      Debug.Log("Starting");
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
