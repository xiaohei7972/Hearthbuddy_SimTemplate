using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_330 : SimTemplate //* 幽暗城商贩 Undercity Huckster
//<b>Deathrattle:</b> Add a random card to your hand <i>(from your opponent's class)</i>.
//<b>亡语：</b>随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。 
	{
		

		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}