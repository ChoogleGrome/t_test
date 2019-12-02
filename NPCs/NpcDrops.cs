// note this is sort of very broken

using Terraria;
using t_test.Items;
using Terraria.ID;
using Terraria.ModLoader;

namespace t_test.NPCs {

    public class NpcDrops : GlobalNPC {

        public override void NPCLoot(NPC npc) {

            if (npc.type == NPCID.EyeofCthulhu) {
                
                if (!t_testWorld.spawnOre){                                                       
                    Main.NewText("The world becomes brighter...", 255, 43, 255);
                    for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 5E-05); k++) {
                        WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY), (double)WorldGen.genRand.Next(5, 9), WorldGen.genRand.Next(9, 12), mod.TileType("AkaruiOreTile"), false, 0f, 0f, false, true);
                    }
                }
                t_testWorld.spawnOre = true;
            
            }


            if (npc.type == NPCID.WallofFlesh) {
                
                if (!t_testWorld.spawnOre){                                                       
                    Main.NewText("The legends approve of your success...", 255, 43, 255);
                    Main.NewText("Your world has been blessed with Kaiyo Ore", 255, 43, 255);
                    for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 5E-05); k++) {
                        WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY), (double)WorldGen.genRand.Next(5, 9), WorldGen.genRand.Next(9, 12), mod.TileType("KaiyoOreTile"), false, 0f, 0f, false, true);
                    }
                }
                t_testWorld.spawnOre = true;
            
            }

            if (Main.hardMode) {
                
                if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight) {
                    if (Main.rand.Next(4) == 0) {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("KasaiEssence"), 1);
                    }
                }

                if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach) {
                    if (Main.rand.Next(4) == 0) {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UmiEssence"), 1);
                    }
                }

                if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneHoly) {
                    if (Main.rand.Next(4) == 0) {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HikariEssence"), 1);
                    }
                }

                if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt) {
                    if (Main.rand.Next(4) == 0) {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DakiEssence"), 1);
                    }
                }
            }

            else {
                if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneHoly) {
                    if (Main.rand.Next(4) == 0) {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HikariEssence"), 1);
                    }
                }
            }
        }
    }
}