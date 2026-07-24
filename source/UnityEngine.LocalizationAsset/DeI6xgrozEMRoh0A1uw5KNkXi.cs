using System;
using SDG.Unturned;
using UnityEngine;

// Token: 0x02000051 RID: 81
public class DeI6xgrozEMRoh0A1uw5KNkXi : DSvAEyoSitLrXzsZSSRwWfJ5T
{
	// Token: 0x0600017B RID: 379 RVA: 0x00014EAC File Offset: 0x000130AC
	public override bool GetAviablity()
	{
		bool independentPlayerInfoTargeting = D5l46jlssr4TRAzUSXzLj0uqu.independentPlayerInfoTargeting;
		if (independentPlayerInfoTargeting)
		{
			Player player = this.D698KmCUp6gd5dWYawZV3B4KQ();
			this.DYs4vgzJwangT6DO91J7FFHm3 = ((player != null) ? new Du4XicP1hVrJzXjQ70aniDyvk(Dr5qliNNQh3jZolh9fn7SFNyi.Player, player, Vector3.zero) : new Du4XicP1hVrJzXjQ70aniDyvk(Dr5qliNNQh3jZolh9fn7SFNyi.Player, null, Vector3.zero));
		}
		else
		{
			this.DYs4vgzJwangT6DO91J7FFHm3 = Ddagemt6Wc3UeyV4EYXNrXcFf.DASEuOZmKRI1v3DQRcsmyTKsC;
		}
		return D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerInfo && (this.DYs4vgzJwangT6DO91J7FFHm3.DnuBpXW8r7IgW3DCiPdbWlBGC != null || D5l46jlssr4TRAzUSXzLj0uqu.displayPlayerInfoAlways);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00014F28 File Offset: 0x00013128
	public Player D698KmCUp6gd5dWYawZV3B4KQ()
	{
		float num = (float)DI8jSvGQa3grzg5wlLxwkRj27.DzGDOq0dZL2sIXJTdcfSy2A4v("Independent player info targeting FOV");
		foreach (SteamPlayer steamPlayer in Provider.clients)
		{
			bool flag = steamPlayer != null && !(steamPlayer.player == null) && !steamPlayer.player.life.isDead && Vector3.Distance(steamPlayer.player.transform.position, Player.player.transform.position) <= (float)D5l46jlssr4TRAzUSXzLj0uqu.independetPlayerInfoTargetingDistance;
			if (flag)
			{
				Vector3 vector = (D5l46jlssr4TRAzUSXzLj0uqu.freeCamera ? DZW7dpbH5Qs7H7R6KJHZs0PUu.DSnFwyDSJiRcayfNoTM5EALne.WorldToScreenPoint(steamPlayer.player.transform.position) : MainCamera.instance.WorldToScreenPoint(steamPlayer.player.transform.position));
				bool flag2 = vector.z >= 0f;
				if (flag2)
				{
					vector.y = (float)Screen.height - vector.y;
					bool flag3 = Vector2.Distance(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), new Vector2(vector.x, vector.y)) <= num;
					if (flag3)
					{
						return steamPlayer.player;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x000150AC File Offset: 0x000132AC
	public override void DrawWindow()
	{
		base.DZxuXSmWDxed28SbJ8XfD3yXH("Target Information");
		Du4XicP1hVrJzXjQ70aniDyvk dys4vgzJwangT6DO91J7FFHm = this.DYs4vgzJwangT6DO91J7FFHm3;
		bool flag = dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC == null;
		if (flag)
		{
			DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("No Target");
		}
		else
		{
			switch (dys4vgzJwangT6DO91J7FFHm.DKr6XbLZDMiJmmxABXHlfTTLz)
			{
			case Dr5qliNNQh3jZolh9fn7SFNyi.Player:
			{
				Player player = (Player)dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC;
				bool flag2 = player != null;
				if (flag2)
				{
					DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Player");
					DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Steam Name: " + player.channel.owner.playerID.playerName);
					DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Character: " + player.channel.owner.playerID.characterName);
					DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Nickname: " + player.channel.owner.playerID.nickName);
					PlayerEquipment equipment = player.equipment;
					bool flag3 = equipment != null && equipment.asset != null;
					if (flag3)
					{
						DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Holding: " + equipment.asset.itemName);
					}
					else
					{
						DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Holding: None");
					}
				}
				else
				{
					DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Player");
					DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Target is null");
				}
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags:
			{
				InteractableClaim interactableClaim = (InteractableClaim)dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC;
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Claim Flag");
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Name: " + interactableClaim.name);
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Beds:
			{
				InteractableBed interactableBed = (InteractableBed)dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC;
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Bed");
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Name: " + interactableBed.name);
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Storages:
			{
				InteractableStorage interactableStorage = (InteractableStorage)dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC;
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Storage");
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Name: " + interactableStorage.name);
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Zombies:
			{
				Zombie zombie = (Zombie)dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC;
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Zombie");
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Status: " + (zombie.isDead ? "Dead" : "Alive"));
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Animals:
			{
				Animal animal = (Animal)dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC;
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Animal");
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Status: " + (animal.isDead ? "Dead" : "Alive"));
				break;
			}
			case Dr5qliNNQh3jZolh9fn7SFNyi.Vehicles:
			{
				InteractableVehicle interactableVehicle = (InteractableVehicle)dys4vgzJwangT6DO91J7FFHm.DnuBpXW8r7IgW3DCiPdbWlBGC;
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Type: Vehicle");
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Name: " + interactableVehicle.asset.vehicleName);
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Health: " + interactableVehicle.health.ToString() + " / " + interactableVehicle.asset.health.ToString());
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Status: " + (interactableVehicle.isLocked ? "Locked" : "Unlocked"));
				break;
			}
			default:
				DqNh7bzS0xEILWgxFJA4tpJpp.DgXmj38MRUJwixi7YN7t50iiF("Unknown Target");
				break;
			}
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x000153EC File Offset: 0x000135EC
	public override Vector2 GetSize()
	{
		bool flag = this.DYs4vgzJwangT6DO91J7FFHm3.DnuBpXW8r7IgW3DCiPdbWlBGC == null;
		int num;
		if (flag)
		{
			num = 1;
		}
		else
		{
			switch (this.DYs4vgzJwangT6DO91J7FFHm3.DKr6XbLZDMiJmmxABXHlfTTLz)
			{
			case Dr5qliNNQh3jZolh9fn7SFNyi.Player:
				num = 5;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.ClaimFlags:
			case Dr5qliNNQh3jZolh9fn7SFNyi.Beds:
			case Dr5qliNNQh3jZolh9fn7SFNyi.Storages:
				num = 2;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.Zombies:
			case Dr5qliNNQh3jZolh9fn7SFNyi.Animals:
				num = 2;
				break;
			case Dr5qliNNQh3jZolh9fn7SFNyi.Vehicles:
				num = 4;
				break;
			default:
				num = 1;
				break;
			}
		}
		float num2 = 28f + (float)num * 18f + 6f;
		return new Vector2(280f, num2);
	}

	// Token: 0x040001D6 RID: 470
	public Du4XicP1hVrJzXjQ70aniDyvk DYs4vgzJwangT6DO91J7FFHm3;
}
