using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_302 : SimTemplate //* 流光之赐 Gift of Luminance
	{
		//Give a minion <b>Divine Shield</b>, then summon a_1/1 copy of it.
		//使一个随从获得<b>圣盾</b>，并召唤一个1/1的复制。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			target.divineshild = true;
			List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			int pos = temp.Count;
			if (pos < 7)
			{
				p.callKid(target.handcard.card, pos, ownplay);
				temp[pos].setMinionToMinion(target);
				p.ownMinions[pos].Hp = 1;
				p.ownMinions[pos].Angr = 1;
			}		
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}
