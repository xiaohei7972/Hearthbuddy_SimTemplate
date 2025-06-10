using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_206p : SimTemplate //* 女王的祝福 blessingofqueens
	{
		//<b>英雄技能</b> 随机使你手牌中的一张随从牌获得+4/+4。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                Handmanager.Handcard hc = p.searchRandomMinionInHand(p.owncards, searchmode.searchLowestCost, GAME_TAGs.Mob);
                if (hc != null)
                {
                    hc.addattack += 4;
                    hc.addHp += 4;
                    p.anzOwnExtraAngrHp += 8;
                }
            }
        }

	}
}
