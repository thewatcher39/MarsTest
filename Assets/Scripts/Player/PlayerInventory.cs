using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WatcherHome
{
	public class PlayerInventory
	{
		private List<Ore> ores;

		public PlayerInventory()
		{
			ores = new List<Ore>();
		}

		public void AddOre(Ore ore)
		{
			ores.Add(ore);
			foreach (var j in ores)
			{
				Debug.Log(j.oreSize  +" | " + j.oreType);
			}
			Debug.Log("____________");
		}
	}
}