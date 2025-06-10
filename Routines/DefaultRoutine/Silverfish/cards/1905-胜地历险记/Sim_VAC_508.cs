using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Trail Mix
	//能量零食
	//Gain 2 Mana Crystals next turn only.
	//仅在下回合，获得两个法力水晶。
	class Sim_VAC_508 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				p.mana+=2;
            }
		}
	}
}
