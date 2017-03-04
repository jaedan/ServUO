﻿using System;

namespace Server.Items
{
    public class AquaGem : BaseDecayingItem
    {
        public override int LabelNumber { get { return 1154244; } } // Aqua Gem

        [Constructable]
        public AquaGem() : base(0x4B48)
        {
            this.Stackable = false;
            this.Weight = 1.0;
            this.Hue = 1916;
            this.LootType = LootType.Blessed;
            this.QuestItem = true;
        }

        public override int Lifespan { get { return 3600; } }

        public AquaGem(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}