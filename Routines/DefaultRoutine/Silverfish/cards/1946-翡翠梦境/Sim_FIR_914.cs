using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Smoldering Strength
	//焚火之力
	//Give a friendly minion +{0}/+{0}.<i>(Upgrades each turn,but discards after {1}!)</i>@Give a friendlyminion +{0}/+{0}.<i>(Discards this turn!)</i>
	//使一个友方随从获得+{0}/+{0}。<i>（每回合都会升级，但本牌会在{1}回合后弃掉！）</i>@使一个友方随从获得+{0}/+{0}。<i>（本牌会在本回合弃掉！）</i>
	class Sim_FIR_914 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
            if (target != null && target.own)
			{
				p.minionGetBuffed(target, 1, 1);
			}
        }

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
            };
		}

	}
}
