using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedWrath : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Wrath Potion");
			Tooltip.SetDefault("Increased damage.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.Wrath, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WrathPotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}
