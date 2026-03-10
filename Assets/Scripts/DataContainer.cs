using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts
{
	public class DataContainer
	{
		static Dictionary<string, object> storage = new Dictionary<string, object>();

		public static string GetObjectAsString(string key)
		{
			return (string)storage[key];
		}

		public static int GetObjectAsInt(string key)
		{
			return (int)storage[key];
		}

		public static float GetObjectAsFloat(string key)
		{
			return (float)storage[key]; 
		}

		public static bool GetObjectAsBool(string key)
		{
			return (bool)storage[key];
        }

		public static object GetObject(string key)
		{
			return storage[key]; 
		}

        public static void SetObject(string key, object value)
		{
			storage[key] = value; 
		}

        /*
         * SetObject("CurrentLevel", "Level1")
		 * GetObjectAsString("CurrentLevel") => "Level1"
		 */
    }
}