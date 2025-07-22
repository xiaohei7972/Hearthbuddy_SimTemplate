using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_846 : SimTemplate //* 活体风暴 Shimmering Tempest
//<b>Deathrattle:</b> Add a random Mage spell to your hand.
//<b>亡语：</b>随机将一张法师法术牌置入你的手牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
	}
}