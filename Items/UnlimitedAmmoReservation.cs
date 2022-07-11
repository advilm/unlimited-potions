using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedAmmoReservation : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Ammo Reservation Potion");
			Tooltip.SetDefault("Save some ammo.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.AmmoReservation, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.AmmoReservationPotion, 30);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
