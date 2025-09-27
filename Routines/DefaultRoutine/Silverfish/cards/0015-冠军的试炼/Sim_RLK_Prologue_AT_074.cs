using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：3
	//Seal of Champions
	//英勇圣印
	//Give a minion+3 Attack and <b>Divine Shield</b>.
	//使一个随从获得+3攻击力和<b>圣盾</b>。
	class Sim_RLK_Prologue_AT_074 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 3, 0);
                target.divineshild = true;
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
