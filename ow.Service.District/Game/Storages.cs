﻿using Microsoft.EntityFrameworkCore;
using ow.Framework.Database.Characters;
using ow.Framework.Database.Storages;
using ow.Framework.Game.Enums;
using ow.Framework.Game.Storage;
using System.Collections.Generic;
using System.Linq;

namespace ow.Service.District.Game
{
    public sealed record Storages
    {
        public EquipableBattleFashionStorage EquippedBattleFashion { get; }
        public EquipableViewFashionStorage EquippedViewFashion { get; }
        public EquipableGearStorage EquippedGear { get; }

        public Storages(CharacterModel model, BinTables tables, ItemContext context)
        {
            EquippedBattleFashion = new(GetItems(context, model, StorageType.EquippedBattleFashion), tables);
            EquippedViewFashion = new(GetItems(context, model, StorageType.EquippedViewFashion), tables);
            EquippedGear = new(GetItems(context, model, StorageType.EquippedGear), tables);
        }

        private static IEnumerable<ItemModel> GetItems(ItemContext context, CharacterModel model, StorageType type)
        {
            foreach (ItemModel itemModel in context.Items.AsNoTracking().Where(c => c.CharacterId == model.Id && c.StorageType == type))
                yield return itemModel;
        }
    }
}