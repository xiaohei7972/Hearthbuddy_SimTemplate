using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_208 : SimTemplate //* 岩石哨兵 Stone Sentinel
//<b>Battlecry:</b> If you played an Elemental last turn, summon two 2/3 Elementals with <b>Taunt</b>.
//<b>战吼：</b>如果你在上个回合使用过元素牌，则召唤两个2/3并具有<b>嘲讽</b>的元素。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_208t); 

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.anzOwnElementalsLastTurn > 0 && own.own)
			{
                p.callKid(kid, own.zonepos - 1, own.own); 
                p.callKid(kid, own.zonepos, own.own);
			}
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