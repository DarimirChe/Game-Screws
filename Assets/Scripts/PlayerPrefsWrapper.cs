using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
	public class PlayerPrefsWrapper : PlayerPrefs
	{
		public static void SetBool(string key, bool value)
		{
			SetInt(key, value ? 1 : 0);
		}

		public static bool GetBool(string key)
		{
			return GetInt(key) == 1;
		}
	}
}
