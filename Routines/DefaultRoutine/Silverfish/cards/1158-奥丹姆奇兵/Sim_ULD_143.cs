using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_143 : SimTemplate //* 法老祝福 Pharaoh's Blessing
	{
		//Give a minion +4/+4, <b>Divine Shield</b>, and <b>Taunt</b>.
		//使一个随从获得+4/+4，<b>圣盾</b>以及<b>嘲讽</b>。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionGetBuffed(target, 4, 4);
			if (target != null && !target.taunt)
			{
				target.taunt = true;
				if (target.own) p.anzOwnTaunt++;
				else p.anzEnemyTaunt++;
			}
			target.divineshild = true;
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
