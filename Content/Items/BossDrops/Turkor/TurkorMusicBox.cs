using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Consolaria.Content.Items.BossDrops.Turkor {
	public class TurkorMusicBox : ModItem {
		public override void SetStaticDefaults () {
			Item.ResearchUnlockCount = 1;
			MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/Turkor"), ModContent.ItemType<TurkorMusicBox>(), ModContent.TileType<Tiles.TurkorMusicBox>());
			ItemID.Sets.ShimmerTransformToItem [Type] = ItemID.MusicBox;
		}

		public override void SetDefaults () {
			int width = 24; int height = width;
			Item.Size = new Vector2(width, height);
			Item.maxStack = 1;

			Item.accessory = true;
			Item.hasVanityEffects = true;

			Item.rare = ItemRarityID.LightRed;
			Item.value = Item.sellPrice(gold: 1);
			Item.DefaultToMusicBox(ModContent.TileType<Tiles.TurkorMusicBox>(), 0);
		}
	}
}