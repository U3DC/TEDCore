
public class AssetBundleData
{
	private static string[] _assetBundleFolders =
	{
            
	};


	public static bool IsAssetBundle(string path)
	{
		#if ASSET_BUNDLE
		for (int cnt = 0; cnt < _assetBundleFolders.Length; cnt++)
		{
			if (path.Contains (_assetBundleFolders [cnt]))
			{
				return true;
			}
		}
		#endif

		return false;
	}


	private static string[] _extension =
	{
		".mp3",
		".prefab",
		".png",
		".jpg",
		".txt",
		".asset",
	};


	public static bool IsLegalExtension(string extension)
	{
		for (int cnt = 0; cnt < _extension.Length; cnt++)
		{
			if (extension.Contains (_extension [cnt]))
			{
				return true;
			}
		}

		return false;
	}
}

