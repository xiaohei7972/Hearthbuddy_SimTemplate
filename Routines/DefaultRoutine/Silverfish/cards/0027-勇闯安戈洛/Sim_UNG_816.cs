using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_816 : SimTemplate //* 卡利莫斯的仆从 Servant of Kalimos
//[x]<b>Battlecry:</b> If you playedan Elemental last turn,_<b>Discover</b> an Elemental.
//<b>战吼：</b>如果你在上个回合使用过元素牌，则<b>发现</b>一张元素牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.anzOwnElementalsLastTurn > 0 && own.own) p.drawACard(CardDB.cardNameEN.hotspringguardian, own.own, true);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),
            };
        }
    }
}