using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Spirit Mount
	//灵魂坐骑
	//[x]Give a minion +1/+2and <b>Spell Damage +1</b>.When it dies, summona Spirit Raptor.
	//使一个随从获得+1/+2和<b>法术伤害+1</b>。当该随从死亡时，召唤一只灵魂迅猛龙。
	class Sim_ONY_012 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			if (target != null)
			{
				p.minionGetBuffed(target, 1, 2);
				target.spellpower++;
				if (target.own) p.spellpower++;
				else p.enemyspellpower++;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
	}
}
