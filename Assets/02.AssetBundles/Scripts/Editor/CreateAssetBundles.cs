using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Sandbox
{
    public class CreateAssetBundles
    {
        [MenuItem("Assets/Create Asset Bundles")]
        private static void BuildAllAssetBundles()
        {
            var assetBundlePath = Application.dataPath + "/../AssetBundles";
            try
            {
                BuildPipeline.BuildAssetBundles(assetBundlePath, BuildAssetBundleOptions.None,
                    EditorUserBuildSettings.activeBuildTarget);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
            }
        }
    }
}
