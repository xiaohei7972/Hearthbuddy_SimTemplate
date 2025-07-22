using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX8_02H_TB : SimTemplate //* 收割 Harvest
//<b>Hero Power</b>Draw a card. Gain a Mana Crystal.
//<b>英雄技能</b>抽一张牌。获得一个法力水晶。 
	{



        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
			
			p.mana = Math.Min(10, p.mana++);
			if (ownplay)
			{
				p.ownMaxMana = Math.Min(10, p.ownMaxMana++);
			}
			else
			{
				p.enemyMaxMana = Math.Min(10, p.enemyMaxMana++);
			}
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