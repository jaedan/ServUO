
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ArmorBazaarAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4271, -2, -1, 10}, {4271, 2, -1, 11}, {4272, 0, -1, 11}// 1	2	3	
			, {4272, 0, -2, 0}, {4272, -1, -1, 11}, {9, -2, -2, 6}// 4	5	6	
			, {9, 2, -2, 6}, {1276, -1, -1, 6}, {1276, -1, 0, 6}// 7	8	9	
			, {1276, -1, 1, 6}, {1276, -1, 2, 6}, {1276, 0, -1, 6}// 10	11	12	
			, {1276, 0, 0, 6}, {1276, 0, 1, 6}, {1276, 0, 2, 6}// 13	14	15	
			, {1276, 1, -1, 6}, {1276, 1, 0, 6}, {1276, 1, 1, 6}// 16	17	18	
			, {1276, 1, 2, 6}, {1276, 2, -1, 6}, {1276, 2, 0, 6}// 19	20	21	
			, {1276, 2, 1, 6}, {1276, 2, 2, 6}, {7621, 0, 2, 6}// 22	23	24	
			, {7622, 1, 2, 6}, {7620, 2, 2, 6}, {5052, -1, -1, 9}// 25	26	27	
			, {5095, 0, -1, 9}, {5097, 1, -1, 11}, {3779, 2, 2, 14}// 28	29	30	
			, {5120, 1, 2, 14}, {3936, 1, 2, 12}, {5046, 2, 2, 10}// 31	32	33	
			, {4272, -2, -1, 11}// 34	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ArmorBazaarAddonDeed();
			}
		}

		[ Constructable ]
		public ArmorBazaarAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public ArmorBazaarAddon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class ArmorBazaarAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ArmorBazaarAddon();
			}
		}

		[Constructable]
		public ArmorBazaarAddonDeed()
		{
			Name = "ArmorBazaar";
		}

		public ArmorBazaarAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}