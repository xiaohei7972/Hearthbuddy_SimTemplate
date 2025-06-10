using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_354 : SimTemplate //* 圣疗术 Lay on Hands
	{
		//Restore #8 Health. Draw_3 cards.
		//恢复#8点生命值，抽三张牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int heal = (ownplay) ? p.getSpellHeal(8) : p.getEnemySpellHeal(8);
            p.minionGetDamageOrHeal(target, -heal);
            for (int i = 0; i < 3; i++)
            {
                //this.owncarddraw++;
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
            
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
