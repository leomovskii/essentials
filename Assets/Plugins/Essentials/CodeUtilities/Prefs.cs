using System;
using System.Globalization;
using UnityEngine;

namespace Essentials {
	public static class Prefs {

		public static bool GetBool(string key, bool defaultValue = false) {
			return PlayerPrefs.GetInt(key, defaultValue ? 1 : 0) == 1;
		}

		public static void SetBool(string key, bool value) {
			PlayerPrefs.SetInt(key, value ? 1 : 0);
		}

		public static long GetLong(string key, long defaultValue = 0L) {
			try {
				var data = PlayerPrefs.GetString(key, defaultValue.ToString(CultureInfo.InvariantCulture));
				return long.Parse(data, CultureInfo.InvariantCulture);

			} catch (FormatException) {
				return 0L;
			}
		}

		public static void SetLong(string key, long value) {
			PlayerPrefs.SetString(key, value.ToString(CultureInfo.InvariantCulture));
		}

		public static double GetDouble(string key, double defaultValue = 0.0) {
			try {
				var data = PlayerPrefs.GetString(key, defaultValue.ToString(CultureInfo.InvariantCulture));
				return double.Parse(data, CultureInfo.InvariantCulture);

			} catch (FormatException) {
				return 0.0;
			}
		}

		public static void SetDouble(string key, double value) {
			PlayerPrefs.SetString(key, value.ToString(CultureInfo.InvariantCulture));
		}

		public static uint GetUint(string key, uint defaultValue = 0u) {
			try {
				var data = PlayerPrefs.GetString(key, defaultValue.ToString(CultureInfo.InvariantCulture));
				return uint.Parse(data, CultureInfo.InvariantCulture);

			} catch (FormatException) {
				return 0;
			}
		}

		public static void SetUint(string key, uint value) {
			PlayerPrefs.SetString(key, value.ToString(CultureInfo.InvariantCulture));
		}
	}
}