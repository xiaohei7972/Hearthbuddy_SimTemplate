using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Cursed Campaign
	//诅咒之旅
	//[x]Give a friendly minion"<b>Deathrattle:</b> Summon twocopies of this minion thatare <b>Dormant</b> for 2 turns."
	//使一个友方随从获得“<b>亡语：</b>召唤本随从的两个<b>休眠</b>2回合的复制。”
	class Sim_TOY_527 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        }
    }
}
