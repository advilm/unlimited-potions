using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPotions.Items
{
	public class UnlimitedObsidianSkin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unlimited Obsidian Skin Potion");
			Tooltip.SetDefault("Go get all that hellstone.");
		}

		public override void UpdateInventory(Player player)
		{
			player.AddBuff(BuffID.ObsidianSkin, 1800);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ObsidianSkinPotion, 30);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}