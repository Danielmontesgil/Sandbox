using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Sandbox
{
    public class DownloadAssetBundles : MonoBehaviour
    {
        [SerializeField] private Image imageTest;
        private void Start()
        {
            StartCoroutine(DownloadAssetBundlesFromServer());
        }

        private IEnumerator DownloadAssetBundlesFromServer()
        {
            string url = "http://localhost:3000/download-asset-bundle";

            using var www = UnityWebRequestAssetBundle.GetAssetBundle(url);
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError ||
                www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError($"Error on the get request at: {url} {www.error}");
            }
            else
            {
                AssetBundle assetBundle = DownloadHandlerAssetBundle.GetContent(www);
                var sprite = assetBundle.LoadAsset<Sprite>(assetBundle.GetAllAssetNames()[0]);
                assetBundle.Unload(false);
                imageTest.sprite = sprite;
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
