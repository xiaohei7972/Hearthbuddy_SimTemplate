using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_041 : SimTemplate //* 风暴之眼 Eye of the Storm
	{
		//Summon three 5/6 Elementals with <b>Taunt</b>. <b>Overload:</b> (3)
		//召唤三个5/6并具有<b>嘲讽</b>的元素。<b>过载：</b>（3）
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOD_041t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
            if (ownplay) p.ueberladung += 3;
        }		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}
