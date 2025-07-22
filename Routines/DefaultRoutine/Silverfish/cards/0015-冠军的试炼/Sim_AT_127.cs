using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_127 : SimTemplate //* 虚灵勇士萨兰德 Nexus-Champion Saraad
//<b>Inspire:</b> Add a random spell to your hand.
//<b>激励：</b>随机将一张法术牌置入你的手牌。 
	{
		
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
                p.drawACard(CardDB.cardNameEN.frostbolt, own, true);
			}
        }
	}
}